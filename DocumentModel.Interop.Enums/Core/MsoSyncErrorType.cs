namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a document synchronization error.
/// </summary>
public enum MsoSyncErrorType
{
  /// <summary>
  /// No error. msoSyncErrorUnauthorizedUser1 Unauthorized user. msoSyncErrorCouldNotConnect2 Could not connect.
  /// </summary>
  msoSyncErrorNone,
  /// <summary>
  /// Specifies a document synchronization error.
  /// </summary>
  msoSyncErrorUnauthorizedUser,
  /// <summary>
  /// Specifies a document synchronization error.
  /// </summary>
  msoSyncErrorCouldNotConnect,
  /// <summary>
  /// Out of space.
  /// </summary>
  msoSyncErrorOutOfSpace,
  /// <summary>
  /// Destination file not found.
  /// </summary>
  msoSyncErrorFileNotFound,
  /// <summary>
  /// File too large to synchronize.
  /// </summary>
  msoSyncErrorFileTooLarge,
  /// <summary>
  /// Destination file in use.
  /// </summary>
  msoSyncErrorFileInUse,
  /// <summary>
  /// Virus uploaded.
  /// </summary>
  msoSyncErrorVirusUpload,
  /// <summary>
  /// Virus downloaded.
  /// </summary>
  msoSyncErrorVirusDownload,
  /// <summary>
  /// Upload error. msoSyncErrorUnknownDownload10 Download error.
  /// </summary>
  msoSyncErrorUnknownUpload,
  /// <summary>
  /// Specifies a document synchronization error.
  /// </summary>
  msoSyncErrorUnknownDownload,
  /// <summary>
  /// Could not open file. msoSyncErrorCouldNotUpdate12 Could not update destination file. public enum class
  /// MsoSyncErrorType ﾉ Expand table msoSyncErrorCouldNotCompare13 Source and destination files could not be
  /// compared.
  /// </summary>
  msoSyncErrorCouldNotOpen,
  /// <summary>
  /// Specifies a document synchronization error.
  /// </summary>
  msoSyncErrorCouldNotUpdate,
  /// <summary>
  /// Specifies a document synchronization error.
  /// </summary>
  msoSyncErrorCouldNotCompare,
  /// <summary>
  /// Could not resolve files.
  /// </summary>
  msoSyncErrorCouldNotResolve,
  /// <summary>
  /// No network available.
  /// </summary>
  msoSyncErrorNoNetwork,
  /// <summary>
  /// Unknown error.
  /// </summary>
  msoSyncErrorUnknown
}
