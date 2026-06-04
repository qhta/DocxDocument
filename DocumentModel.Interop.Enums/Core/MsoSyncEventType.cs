namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the return value of a Sync event.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosynceventtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoSyncEventType))]
public enum SyncEventType
{
  /// <summary>
  /// Download initiated.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncEventType.msoSyncEventDownloadInitiated))]
  DownloadInitiated,
  /// <summary>
  /// Download succeeded.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncEventType.msoSyncEventDownloadSucceeded))]
  DownloadSucceeded,
  /// <summary>
  /// Download failed.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncEventType.msoSyncEventDownloadFailed))]
  DownloadFailed,
  /// <summary>
  /// Upload initiated.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncEventType.msoSyncEventUploadInitiated))]
  UploadInitiated,
  /// <summary>
  /// Upload succeeded.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncEventType.msoSyncEventUploadSucceeded))]
  UploadSucceeded,
  /// <summary>
  /// Upload failed.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncEventType.msoSyncEventUploadFailed))]
  UploadFailed,
  /// <summary>
  /// No change detected.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncEventType.msoSyncEventDownloadNoChange))]
  DownloadNoChange,
  /// <summary>
  /// Offline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncEventType.msoSyncEventOffline))]
  Offline
}
