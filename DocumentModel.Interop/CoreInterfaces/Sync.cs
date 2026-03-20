using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface Sync: InteropObject
{
  public MsoSyncStatusType Status { get; }
  public string WorkspaceLastChangedBy { get; }
  public object LastSyncTime { get; }
  public MsoSyncErrorType ErrorType { get; }
}
