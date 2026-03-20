using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceFolder
{
  public void Delete(object DeleteEventIfFolderContainsFiles);
}
