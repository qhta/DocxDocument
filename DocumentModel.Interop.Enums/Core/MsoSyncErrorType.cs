namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a document synchronization error.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncerrortype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoSyncErrorType
{
  /// <summary>
  /// No error. msoSyncErrorUnauthorizedUser1 Unauthorized user. msoSyncErrorCouldNotConnect2 Could not connect.
  /// </summary>
  None,
  /// <summary>
  /// Specifies a document synchronization error.
  /// </summary>
  UnauthorizedUser,
  /// <summary>
  /// Specifies a document synchronization error.
  /// </summary>
  CouldNotConnect,
  /// <summary>
  /// Out of space.
  /// </summary>
  OutOfSpace,
  /// <summary>
  /// Destination file not found.
  /// </summary>
  FileNotFound,
  /// <summary>
  /// File too large to synchronize.
  /// </summary>
  FileTooLarge,
  /// <summary>
  /// Destination file in use.
  /// </summary>
  FileInUse,
  /// <summary>
  /// Virus uploaded.
  /// </summary>
  VirusUpload,
  /// <summary>
  /// Virus downloaded.
  /// </summary>
  VirusDownload,
  /// <summary>
  /// Upload error. msoSyncErrorUnknownDownload10 Download error.
  /// </summary>
  UnknownUpload,
  /// <summary>
  /// Specifies a document synchronization error.
  /// </summary>
  UnknownDownload,
  /// <summary>
  /// Could not open file. msoSyncErrorCouldNotUpdate12 Could not update destination file. public enum class
  /// MsoSyncErrorType ﾉ Expand table msoSyncErrorCouldNotCompare13 Source and destination files could not be
  /// compared.
  /// </summary>
  CouldNotOpen,
  /// <summary>
  /// Specifies a document synchronization error.
  /// </summary>
  CouldNotUpdate,
  /// <summary>
  /// Specifies a document synchronization error.
  /// </summary>
  CouldNotCompare,
  /// <summary>
  /// Could not resolve files.
  /// </summary>
  CouldNotResolve,
  /// <summary>
  /// No network available.
  /// </summary>
  NoNetwork,
  /// <summary>
  /// Unknown error.
  /// </summary>
  Unknown
}
