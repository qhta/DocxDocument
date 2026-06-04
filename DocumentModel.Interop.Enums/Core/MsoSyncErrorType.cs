namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a document synchronization error.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncerrortype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoSyncErrorType")]
public enum SyncErrorType
{
  /// <summary>
  /// No error.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorNone")]
  None,
  /// <summary>
  /// Unauthorized user.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorUnauthorizedUser")]
  UnauthorizedUser,
  /// <summary>
  /// Could not connect.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorCouldNotConnect")]
  CouldNotConnect,
  /// <summary>
  /// Out of space.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorOutOfSpace")]
  OutOfSpace,
  /// <summary>
  /// Destination file not found.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorFileNotFound")]
  FileNotFound,
  /// <summary>
  /// File too large to synchronize.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorFileTooLarge")]
  FileTooLarge,
  /// <summary>
  /// Destination file in use.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorFileInUse")]
  FileInUse,
  /// <summary>
  /// Virus uploaded.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorVirusUpload")]
  VirusUpload,
  /// <summary>
  /// Virus downloaded.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorVirusDownload")]
  VirusDownload,
  /// <summary>
  /// Upload error.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorUnknownUpload")]
  UnknownUpload,
  /// <summary>
  /// Download error.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorUnknownDownload")]
  UnknownDownload,
  /// <summary>
  /// Could not open file.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorCouldNotOpen")]
  CouldNotOpen,
  /// <summary>
  /// Could not update destination file.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorCouldNotUpdate")]
  CouldNotUpdate,
  /// <summary>
  /// Source and destination files could not be compared.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorCouldNotCompare")]
  CouldNotCompare,
  /// <summary>
  /// Could not resolve files.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorCouldNotResolve")]
  CouldNotResolve,
  /// <summary>
  /// No network available.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorNoNetwork")]
  NoNetwork,
  /// <summary>
  /// Unknown error.
  /// </summary>
  [OfficeInteropEnumValue("msoSyncErrorUnknown")]
  Unknown
}
