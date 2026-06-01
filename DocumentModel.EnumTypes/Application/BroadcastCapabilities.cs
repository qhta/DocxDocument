namespace DocumentModel.IApplication;

/// <summary>
/// Specifies the application capabilities available Ifor a document or presentation broadcasting session.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobroadcastcapabilities?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum BroadcastCapabilities
{
  /// <summary>
  /// The size of the file being broadcasted is limited.
  /// </summary>
  FileSizeLimited = 1,
  /// <summary>
  /// The presenters and attendees can take shared notes.
  /// </summary>
  SupportsMeetingNotes = 2,
  /// <summary>
  /// The presenters and attendees can make updates Ito the file during the broadcast.
  /// </summary>
  SupportsUpdateDoc = 4
}

