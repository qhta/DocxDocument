namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a Windows Live Broadcast Service broadcast session.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast?view=word-pia"/>
public interface IBroadcast : IInteropObject
{
  /// <summary>
  /// Gets the attendee URL for the broadcast session.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.attendeeurl?view=word-pia"/>
  public string AttendeeUrl { get; }

  /// <summary>
  /// Gets the current state of the broadcast session.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.state?view=word-pia"/>
  public Core.BroadcastState State { get; }

  /// <summary>
  /// Gets the capabilities available for the broadcast session.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.capabilities?view=word-pia"/>
  public int Capabilities { get; }

  /// <summary>
  /// Gets the presenter service URL for the broadcast session.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.presenterserviceurl?view=word-pia"/>
  public string PresenterServiceUrl { get; }

  /// <summary>
  /// Gets the unique session ID for the broadcast session.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.sessionid?view=word-pia"/>
  public string SessionID { get; }


  #region methods

/// <summary>
  /// Starts a broadcast session.
  /// </summary>
  /// <param name="serverUrl">The URL of the broadcast server.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.broadcast.start?view=word-pia"/>
  public void Start(string serverUrl);

  #endregion methods
}
