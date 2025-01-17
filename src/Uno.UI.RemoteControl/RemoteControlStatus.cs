using System;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Uno.UI.RemoteControl;

public record RemoteControlStatus(
	RemoteControlStatus.ConnectionState State,
	bool? IsVersionValid,
	(RemoteControlStatus.KeepAliveState State, long RoundTrip) KeepAlive,
	ImmutableHashSet<RemoteControlStatus.MissingProcessor> MissingRequiredProcessors,
	(long Count, ImmutableHashSet<Type> Types) InvalidFrames)
{

	/// <summary>
	/// A boolean indicating if everything is fine with the connection and the handshaking succeeded.
	/// </summary>
	public bool IsAllGood =>
		State == ConnectionState.Connected
#if !DEBUG
		// For debug builds, it's annoying to have the version mismatch preventing the connection
		// Only Uno devs should get this issue, let's not block them.
		&& IsVersionValid == true
#endif
		&& MissingRequiredProcessors.IsEmpty
		&& KeepAlive.State == KeepAliveState.Ok
		&& InvalidFrames.Count == 0;

	/// <summary>
	/// If the connection is problematic, meaning that the connection is not in a good state.
	/// </summary>
	/// <remarks>
	/// It's just a negation of <see cref="IsAllGood"/>.
	/// </remarks>
	public bool IsProblematic => !IsAllGood;

	public (Classification kind, string message) GetSummary()
	{
		var (kind, message) = State switch
		{
			ConnectionState.Idle => (Classification.Info, "Initializing..."),
			ConnectionState.NoServer => (Classification.Error, "No server configured, cannot initialize connection."),
			ConnectionState.Connecting => (Classification.Info, "Connecting to IDE."),
			ConnectionState.ConnectionTimeout => (Classification.Error, "Failed to connect to IDE (timeout)."),
			ConnectionState.ConnectionFailed => (Classification.Error, "Failed to connect to IDE (error)."),
			ConnectionState.Reconnecting => (Classification.Info, "Connection to IDE has been lost, reconnecting."),
			ConnectionState.Disconnected => (Classification.Error, "Connection to IDE has been lost, will retry later."),

			ConnectionState.Connected when IsVersionValid is false => (Classification.Warning, "Connected to IDE, but version mis-match with client."),
			ConnectionState.Connected when InvalidFrames.Count is not 0 => (Classification.Warning, $"Connected to IDE, but received {InvalidFrames.Count} invalid frames."),
			ConnectionState.Connected when MissingRequiredProcessors is { IsEmpty: false } => (Classification.Warning, "Connected to IDE, but some required processors are missing on it."),
			ConnectionState.Connected when KeepAlive.State is KeepAliveState.Late => (Classification.Info, "Connected to IDE, but keep-alive messages are taking longer than expected."),
			ConnectionState.Connected when KeepAlive.State is KeepAliveState.Lost => (Classification.Warning, "Connected to IDE, but last keep-alive messages has been lost."),
			ConnectionState.Connected when KeepAlive.State is KeepAliveState.Aborted => (Classification.Warning, "Connected to IDE, but keep-alive has been aborted."),
			ConnectionState.Connected => (Classification.Ok, "Connected to IDE."),

			_ => (Classification.Warning, State.ToString()),
		};

		if (KeepAlive.RoundTrip >= 0)
		{
			message += $" (ping {KeepAlive.RoundTrip}ms)";
		}

		return (kind, message);
	}

	internal string GetDescription()
	{
		var details = new StringBuilder(GetSummary().message);

		if (MissingRequiredProcessors is { Count: > 0 } missing)
		{
			details.AppendLine();
			details.AppendLine();
			details.AppendLine("Some processor(s) requested by the client are missing on the IDE:");

			foreach (var m in missing)
			{
				details.AppendLine($"- {m.TypeFullName}: {m.Details}");
				if (m.Error is not null)
				{
					details.AppendLine($"  {m.Error}");
				}
			}
		}

		if (InvalidFrames.Types is { Count: > 0 } invalidFrameTypes)
		{
			details.AppendLine();
			details.AppendLine();
			details.AppendLine($"Received {InvalidFrames.Count} invalid frames from the IDE. Failing frame types ({invalidFrameTypes.Count}):");

			foreach (var type in invalidFrameTypes)
			{
				details.AppendLine($"- {type.Name}");
			}
		}

		return details.ToString();
	}

	public readonly record struct MissingProcessor(string TypeFullName, string Version, string Details, string? Error = null);

	public enum KeepAliveState
	{
		Idle,
		Ok, // Got ping/pong in expected delays
		Late, // Sent ping without response within delay
		Lost, // Got an invalid pong response
		Aborted // KeepAlive was aborted
	}

	public enum ConnectionState
	{
		/// <summary>
		/// Client as not been started yet
		/// </summary>
		Idle,

		/// <summary>
		/// No server information to connect to.
		/// </summary>
		NoServer,

		/// <summary>
		/// Attempting to connect to the server.
		/// </summary>
		Connecting,

		/// <summary>
		/// Reach timeout while trying to connect to the server.
		/// Connection HAS NOT been established.
		/// </summary>
		ConnectionTimeout,

		/// <summary>
		/// Connection to the server failed.
		/// Connection HAS NOT been established.
		/// </summary>
		ConnectionFailed,

		/// <summary>
		/// Connection to the server has been established.
		/// </summary>
		Connected,

		/// <summary>
		/// Reconnecting to the server.
		/// Connection has been established once but lost since then, reconnecting to the SAME server.
		/// </summary>
		Reconnecting,

		/// <summary>
		/// Disconnected from the server.
		/// Connection has been established once but lost since then and cannot be restored for now but will be retried later.
		/// </summary>
		Disconnected
	}

	public enum Classification
	{
		Ok,
		Info,
		Warning,
		Error
	}
}
