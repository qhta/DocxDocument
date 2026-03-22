namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the application capabilities available for a document or presentation broadcasting session.
/// </summary>
public enum MsoBroadcastCapabilities
{
  /// <summary>
  /// The size of the file being broadcasted is limited. BroadcastCapSupportsMeetingNotes2 The presenters and
  /// attendees can take shared notes. BroadcastCapSupportsUpdateDoc4 The presenters and attendees can make updates
  /// to the file during the broadcast.
  /// </summary>
  FileSizeLimited = 1,
  /// <summary>
  /// Specifies the application capabilities available for a document or presentation broadcasting session.
  /// </summary>
  SupportsMeetingNotes = 2,
  /// <summary>
  /// Specifies the application capabilities available for a document or presentation broadcasting session.
  /// </summary>
  SupportsUpdateDoc = 4
}
