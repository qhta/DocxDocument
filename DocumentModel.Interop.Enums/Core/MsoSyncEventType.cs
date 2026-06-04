namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the return value of a Sync event.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosynceventtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSyncEventType")]
public enum SyncEventType
{
  /// <summary>
  /// Download initiated.
  /// </summary>
  [InteropEnumValue("msoSyncEventDownloadInitiated")]
  DownloadInitiated,
  /// <summary>
  /// Download succeeded.
  /// </summary>
  [InteropEnumValue("msoSyncEventDownloadSucceeded")]
  DownloadSucceeded,
  /// <summary>
  /// Download failed.
  /// </summary>
  [InteropEnumValue("msoSyncEventDownloadFailed")]
  DownloadFailed,
  /// <summary>
  /// Upload initiated.
  /// </summary>
  [InteropEnumValue("msoSyncEventUploadInitiated")]
  UploadInitiated,
  /// <summary>
  /// Upload succeeded.
  /// </summary>
  [InteropEnumValue("msoSyncEventUploadSucceeded")]
  UploadSucceeded,
  /// <summary>
  /// Upload failed.
  /// </summary>
  [InteropEnumValue("msoSyncEventUploadFailed")]
  UploadFailed,
  /// <summary>
  /// No change detected.
  /// </summary>
  [InteropEnumValue("msoSyncEventDownloadNoChange")]
  DownloadNoChange,
  /// <summary>
  /// Offline.
  /// </summary>
  [InteropEnumValue("msoSyncEventOffline")]
  Offline
}
