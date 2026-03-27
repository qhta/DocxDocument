namespace DocumentModel.Drawings;

/// <summary>
/// Specifies a document synchronization error.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncerrortype?view=office-pia` for Office interop details.
/// </remarks>
public enum SyncErrorType
{
  /// <summary>
  /// No error.
  /// </summary>
  None,
  /// <summary>
  /// Unauthorized user.
  /// </summary>
  UnauthorizedUser,
  /// <summary>
  /// Could not connect.
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
  /// Upload error.
  /// </summary>
  UnknownUpload,
  /// <summary>
  /// Download error.
  /// </summary>
  UnknownDownload,
  /// <summary>
  /// Could not open file.
  /// </summary>
  CouldNotOpen,
  /// <summary>
  /// Could not update destination file.
  /// </summary>
  CouldNotUpdate,
  /// <summary>
  /// Source and destination files could not be compared.
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
