using System;
using System.Drawing;
using Uno.UI.Samples.Controls;
using Microsoft.UI.Xaml.Controls;
using Size = Windows.Foundation.Size;

#if __SKIA__
using Silk.NET.OpenGL;
#endif

namespace UITests.Shared.Windows_UI_Composition
{
	[Sample("Microsoft.UI.Composition")]
	public sealed partial class GLCanvasElement_Simple : UserControl
	{
		public GLCanvasElement_Simple()
		{
			this.InitializeComponent();
		}
	}

#if __SKIA__
	public class GlCanvasElementImpl() : GLCanvasElement(new Size(800, 600))
#else
	public class GlCanvasElementImpl : FrameworkElement
#endif
	{
#if __SKIA__
		private int _counter;
		private uint _vao;
		private uint _vbo;
		private uint _program;

		unsafe protected override void Init(GL gl)
		{
			_vao = gl.GenVertexArray();
	        gl.BindVertexArray(_vao);

			float[] vertices =
			{
				0.5f, -0.5f, 0.0f,  // bottom right
				-0.5f, -0.5f, 0.0f,  // bottom left
				0.0f,  0.5f, 0.0f   // top
			};

	        _vbo = gl.GenBuffer();
	        gl.BindBuffer(BufferTargetARB.ArrayBuffer, _vbo);
	        gl.BufferData(BufferTargetARB.ArrayBuffer, new ReadOnlySpan<float>(vertices), BufferUsageARB.StaticDraw);

			gl.VertexAttribPointer(0, 3, GLEnum.Float, false, 3 * sizeof(float), (void*)0);
			gl.EnableVertexAttribArray(0);

		    const string vertexCode = @"
#version 330 core

layout (location = 0) in vec3 aPosition;
out vec4 vertexColor;

void main()
{
    gl_Position = vec4(aPosition, 1.0);
	vertexColor = vec4(aPosition.x + 0.5, aPosition.y + 0.5, aPosition.z + 0.5, 1.0);
}";

	        const string fragmentCode = @"
#version 330 core

out vec4 out_color;
in vec4 vertexColor;

void main()
{
	out_color = vertexColor;
}";

	        uint vertexShader = gl.CreateShader(ShaderType.VertexShader);
	        gl.ShaderSource(vertexShader, vertexCode);
	        gl.CompileShader(vertexShader);

	        gl.GetShader(vertexShader, ShaderParameterName.CompileStatus, out int vStatus);
	        if (vStatus != (int) GLEnum.True)
	            throw new Exception("Vertex shader failed to compile: " + gl.GetShaderInfoLog(vertexShader));

	        uint fragmentShader = gl.CreateShader(ShaderType.FragmentShader);
	        gl.ShaderSource(fragmentShader, fragmentCode);
	        gl.CompileShader(fragmentShader);

	        gl.GetShader(fragmentShader, ShaderParameterName.CompileStatus, out int fStatus);
	        if (fStatus != (int) GLEnum.True)
	            throw new Exception("Fragment shader failed to compile: " + gl.GetShaderInfoLog(fragmentShader));

	        _program = gl.CreateProgram();
	        gl.AttachShader(_program, vertexShader);
	        gl.AttachShader(_program, fragmentShader);
	        gl.LinkProgram(_program);

	        gl.GetProgram(_program, ProgramPropertyARB.LinkStatus, out int lStatus);
	        if (lStatus != (int) GLEnum.True)
	            throw new Exception("Program failed to link: " + gl.GetProgramInfoLog(_program));

	        gl.DetachShader(_program, vertexShader);
	        gl.DetachShader(_program, fragmentShader);
	        gl.DeleteShader(vertexShader);
	        gl.DeleteShader(fragmentShader);
		}

		protected override void OnDestroy(GL gl)
		{
			gl.DeleteVertexArray(_vao);
			gl.DeleteBuffer(_vbo);
			gl.DeleteProgram(_program);
		}

		protected override void RenderOverride(GL gl)
		{
			gl.ClearColor(Color.FromArgb(_counter++ % 255, 0, 0));
			gl.Clear(ClearBufferMask.ColorBufferBit);

			gl.UseProgram(_program);

			gl.BindVertexArray(_vao);
			gl.DrawArrays(PrimitiveType.Triangles, 0, 3);

			Invalidate(); // continuous redrawing
		}
#endif
	}
}
