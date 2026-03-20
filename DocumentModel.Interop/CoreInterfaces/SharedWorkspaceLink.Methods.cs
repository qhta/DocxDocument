using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceLink
{
  public void Save();
  public void Delete();
}
