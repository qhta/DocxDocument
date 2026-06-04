namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a document synchronization error.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncerrortype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoSyncErrorType))]
public enum SyncErrorType
{
  /// <summary>
  /// No error.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorNone))]
  None,
  /// <summary>
  /// Unauthorized user.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorUnauthorizedUser))]
  UnauthorizedUser,
  /// <summary>
  /// Could not connect.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorCouldNotConnect))]
  CouldNotConnect,
  /// <summary>
  /// Out of space.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorOutOfSpace))]
  OutOfSpace,
  /// <summary>
  /// Destination file not found.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorFileNotFound))]
  FileNotFound,
  /// <summary>
  /// File too large to synchronize.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorFileTooLarge))]
  FileTooLarge,
  /// <summary>
  /// Destination file in use.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorFileInUse))]
  FileInUse,
  /// <summary>
  /// Virus uploaded.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorVirusUpload))]
  VirusUpload,
  /// <summary>
  /// Virus downloaded.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorVirusDownload))]
  VirusDownload,
  /// <summary>
  /// Upload error.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorUnknownUpload))]
  UnknownUpload,
  /// <summary>
  /// Download error.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorUnknownDownload))]
  UnknownDownload,
  /// <summary>
  /// Could not open file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorCouldNotOpen))]
  CouldNotOpen,
  /// <summary>
  /// Could not update destination file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorCouldNotUpdate))]
  CouldNotUpdate,
  /// <summary>
  /// Source and destination files could not be compared.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorCouldNotCompare))]
  CouldNotCompare,
  /// <summary>
  /// Could not resolve files.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorCouldNotResolve))]
  CouldNotResolve,
  /// <summary>
  /// No network available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorNoNetwork))]
  NoNetwork,
  /// <summary>
  /// Unknown error.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncErrorType.msoSyncErrorUnknown))]
  Unknown
}
