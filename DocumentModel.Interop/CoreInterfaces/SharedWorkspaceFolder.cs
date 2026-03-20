using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceFolder: InteropObject
{
  public string FolderName { get; }
}
