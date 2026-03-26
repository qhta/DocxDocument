namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the return value of a Sync event.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosynceventtype?view=office-pia` for Office interop details.
/// </remarks>
public enum SyncEventType
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
