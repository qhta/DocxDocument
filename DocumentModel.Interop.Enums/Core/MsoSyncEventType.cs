namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the return value of a Sync event.
/// </summary>
public enum MsoSyncEventType
{
  /// <summary>
  /// Download initiated.
  /// </summary>
  DownloadInitiated,
  /// <summary>
  /// Download succeeded.
  /// </summary>
  DownloadSucceeded,
  /// <summary>
  /// Download failed.
  /// </summary>
  DownloadFailed,
  /// <summary>
  /// Upload initiated.
  /// </summary>
  UploadInitiated,
  /// <summary>
  /// Upload succeeded.
  /// </summary>
  UploadSucceeded,
  /// <summary>
  /// Upload failed.
  /// </summary>
  UploadFailed,
  /// <summary>
  /// No change detected.
  /// </summary>
  DownloadNoChange,
  /// <summary>
  /// Offline.
  /// </summary>
  Offline
}
