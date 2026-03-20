namespace DocumentModel.Interop.Core;

public enum MsoSyncErrorType
{
  msoSyncErrorNone,
  msoSyncErrorUnauthorizedUser,
  msoSyncErrorCouldNotConnect,
  msoSyncErrorOutOfSpace,
  msoSyncErrorFileNotFound,
  msoSyncErrorFileTooLarge,
  msoSyncErrorFileInUse,
  msoSyncErrorVirusUpload,
  msoSyncErrorVirusDownload,
  msoSyncErrorUnknownUpload,
  msoSyncErrorUnknownDownload,
  msoSyncErrorCouldNotOpen,
  msoSyncErrorCouldNotUpdate,
  msoSyncErrorCouldNotCompare,
  msoSyncErrorCouldNotResolve,
  msoSyncErrorNoNetwork,
  msoSyncErrorUnknown
}