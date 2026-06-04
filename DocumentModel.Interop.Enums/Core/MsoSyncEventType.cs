namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the return value of a Sync event.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosynceventtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoSyncEventType")]
public enum SyncEventType
{
  /// <summary>
  /// Download initiated.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncEventDownloadInitiated")]
  DownloadInitiated,
  /// <summary>
  /// Download succeeded.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncEventDownloadSucceeded")]
  DownloadSucceeded,
  /// <summary>
  /// Download failed.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncEventDownloadFailed")]
  DownloadFailed,
  /// <summary>
  /// Upload initiated.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncEventUploadInitiated")]
  UploadInitiated,
  /// <summary>
  /// Upload succeeded.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncEventUploadSucceeded")]
  UploadSucceeded,
  /// <summary>
  /// Upload failed.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncEventUploadFailed")]
  UploadFailed,
  /// <summary>
  /// No change detected.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncEventDownloadNoChange")]
  DownloadNoChange,
  /// <summary>
  /// Offline.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncEventOffline")]
  Offline
}
