namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a Windows Live Broadcast Service broadcast session.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast?view=word-pia"/>
public partial interface Broadcast : InteropObject
{
  /// <summary>
  /// The attendee url.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.attendeeurl?view=word-pia"/>
  public string AttendeeUrl { get; }

  /// <summary>
  /// The state.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.state?view=word-pia"/>
  public Core.MsoBroadcastState State { get; }

  /// <summary>
  /// The capabilities.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.capabilities?view=word-pia"/>
  public int Capabilities { get; }

  /// <summary>
  /// The presenter service url.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.presenterserviceurl?view=word-pia"/>
  public string PresenterServiceUrl { get; }

  /// <summary>
  /// The session id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.sessionid?view=word-pia"/>
  public string SessionID { get; }
}
