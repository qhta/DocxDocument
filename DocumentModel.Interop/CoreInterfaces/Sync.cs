using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface Sync: InteropObject
{
  public MsoSyncStatusType Status { get; }
  public string WorkspaceLastChangedBy { get; }
  public object LastSyncTime { get; }
  public MsoSyncErrorType ErrorType { get; }
  public void GetUpdate();
  public void PutUpdate();
  public void OpenVersion(MsoSyncVersionType SyncVersionType);
  public void ResolveConflict(MsoSyncConflictResolutionType SyncConflictResolution);
  public void Unsuspend();
}
