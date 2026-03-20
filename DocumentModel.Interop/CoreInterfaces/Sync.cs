using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface Sync: InteropObject
{
  MsoSyncStatusType Status { get; }
  string WorkspaceLastChangedBy { get; }
  object LastSyncTime { get; }
  MsoSyncErrorType ErrorType { get; }
  void GetUpdate();
  void PutUpdate();
  void OpenVersion(MsoSyncVersionType SyncVersionType);
  void ResolveConflict(MsoSyncConflictResolutionType SyncConflictResolution);
  void Unsuspend();
}