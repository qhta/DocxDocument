namespace DocumentModel.Interop;

/// <summary>
/// Represents a Windows Live Broadcast Service broadcast session.
/// </summary>
public partial interface Broadcast : InteropObject
{
  /// <summary>
  /// The attendee url.
  /// </summary>
  public string AttendeeUrl { get; }

  /// <summary>
  /// The state.
  /// </summary>
  //public Core.MsoBroadcastState State { get; }

  /// <summary>
  /// The capabilities.
  /// </summary>
  public int Capabilities { get; }

  /// <summary>
  /// The presenter service url.
  /// </summary>
  public string PresenterServiceUrl { get; }

  /// <summary>
  /// The session id.
  /// </summary>
  public string SessionID { get; }
}
