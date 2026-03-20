using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceTask
{
  public void Save();
  public void Delete();
}
