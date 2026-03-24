namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the application capabilities available for a document or presentation broadcasting session.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobroadcastcapabilities?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoBroadcastCapabilities
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
  /// The presenters and attendees can make updates to the file during the broadcast.
  /// </summary>
  SupportsUpdateDoc = 4
}
