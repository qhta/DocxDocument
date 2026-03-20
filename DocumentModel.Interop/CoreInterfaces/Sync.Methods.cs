using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface Sync
{
  public void GetUpdate();
  public void PutUpdate();
  public void OpenVersion(MsoSyncVersionType SyncVersionType);
  public void ResolveConflict(MsoSyncConflictResolutionType SyncConflictResolution);
  public void Unsuspend();
}
