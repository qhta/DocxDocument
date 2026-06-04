namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the application capabilities available for a document or presentation broadcasting session.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobroadcastcapabilities?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoBroadcastCapabilities")]
public enum BroadcastCapabilities
{
  /// <summary>
  /// The size of the file being broadcasted is limited.
  /// </summary>
  [OfficeInteropEnumValue("BroadcastCapFileSizeLimited")]
  FileSizeLimited = 1,
  /// <summary>
  /// The presenters and attendees can take shared notes.
  /// </summary>
  [OfficeInteropEnumValue("BroadcastCapSupportsMeetingNotes")]
  SupportsMeetingNotes = 2,
  /// <summary>
  /// The presenters and attendees can make updates to the file during the broadcast.
  /// </summary>
  [OfficeInteropEnumValue("BroadcastCapSupportsUpdateDoc")]
  SupportsUpdateDoc = 4
}
