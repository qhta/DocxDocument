namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a document synchronization error.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncerrortype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSyncErrorType")]
public enum SyncErrorType
{
  /// <summary>
  /// No error.
  /// </summary>
  [InteropEnumValue("msoSyncErrorNone")]
  None,
  /// <summary>
  /// Unauthorized user.
  /// </summary>
  [InteropEnumValue("msoSyncErrorUnauthorizedUser")]
  UnauthorizedUser,
  /// <summary>
  /// Could not connect.
  /// </summary>
  [InteropEnumValue("msoSyncErrorCouldNotConnect")]
  CouldNotConnect,
  /// <summary>
  /// Out of space.
  /// </summary>
  [InteropEnumValue("msoSyncErrorOutOfSpace")]
  OutOfSpace,
  /// <summary>
  /// Destination file not found.
  /// </summary>
  [InteropEnumValue("msoSyncErrorFileNotFound")]
  FileNotFound,
  /// <summary>
  /// File too large to synchronize.
  /// </summary>
  [InteropEnumValue("msoSyncErrorFileTooLarge")]
  FileTooLarge,
  /// <summary>
  /// Destination file in use.
  /// </summary>
  [InteropEnumValue("msoSyncErrorFileInUse")]
  FileInUse,
  /// <summary>
  /// Virus uploaded.
  /// </summary>
  [InteropEnumValue("msoSyncErrorVirusUpload")]
  VirusUpload,
  /// <summary>
  /// Virus downloaded.
  /// </summary>
  [InteropEnumValue("msoSyncErrorVirusDownload")]
  VirusDownload,
  /// <summary>
  /// Upload error.
  /// </summary>
  [InteropEnumValue("msoSyncErrorUnknownUpload")]
  UnknownUpload,
  /// <summary>
  /// Download error.
  /// </summary>
  [InteropEnumValue("msoSyncErrorUnknownDownload")]
  UnknownDownload,
  /// <summary>
  /// Could not open file.
  /// </summary>
  [InteropEnumValue("msoSyncErrorCouldNotOpen")]
  CouldNotOpen,
  /// <summary>
  /// Could not update destination file.
  /// </summary>
  [InteropEnumValue("msoSyncErrorCouldNotUpdate")]
  CouldNotUpdate,
  /// <summary>
  /// Source and destination files could not be compared.
  /// </summary>
  [InteropEnumValue("msoSyncErrorCouldNotCompare")]
  CouldNotCompare,
  /// <summary>
  /// Could not resolve files.
  /// </summary>
  [InteropEnumValue("msoSyncErrorCouldNotResolve")]
  CouldNotResolve,
  /// <summary>
  /// No network available.
  /// </summary>
  [InteropEnumValue("msoSyncErrorNoNetwork")]
  NoNetwork,
  /// <summary>
  /// Unknown error.
  /// </summary>
  [InteropEnumValue("msoSyncErrorUnknown")]
  Unknown
}
