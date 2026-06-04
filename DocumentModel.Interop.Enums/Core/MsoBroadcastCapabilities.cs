namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the application capabilities available for a document or presentation broadcasting session.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobroadcastcapabilities?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoBroadcastCapabilities))]
public enum BroadcastCapabilities
{
  /// <summary>
  /// The size of the file being broadcasted is limited.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBroadcastCapabilities.BroadcastCapFileSizeLimited))]
  FileSizeLimited = 1,
  /// <summary>
  /// The presenters and attendees can take shared notes.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBroadcastCapabilities.BroadcastCapSupportsMeetingNotes))]
  SupportsMeetingNotes = 2,
  /// <summary>
  /// The presenters and attendees can make updates to the file during the broadcast.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoBroadcastCapabilities.BroadcastCapSupportsUpdateDoc))]
  SupportsUpdateDoc = 4
}
