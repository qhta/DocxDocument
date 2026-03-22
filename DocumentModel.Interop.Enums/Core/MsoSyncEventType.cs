namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the return value of a Sync event.
/// </summary>
public enum MsoSyncEventType
{
  /// <summary>
  /// Download initiated.
  /// </summary>
  msoSyncEventDownloadInitiated,
  /// <summary>
  /// Download succeeded.
  /// </summary>
  msoSyncEventDownloadSucceeded,
  /// <summary>
  /// Download failed.
  /// </summary>
  msoSyncEventDownloadFailed,
  /// <summary>
  /// Upload initiated.
  /// </summary>
  msoSyncEventUploadInitiated,
  /// <summary>
  /// Upload succeeded.
  /// </summary>
  msoSyncEventUploadSucceeded,
  /// <summary>
  /// Upload failed.
  /// </summary>
  msoSyncEventUploadFailed,
  /// <summary>
  /// No change detected.
  /// </summary>
  msoSyncEventDownloadNoChange,
  /// <summary>
  /// Offline.
  /// </summary>
  msoSyncEventOffline
}
