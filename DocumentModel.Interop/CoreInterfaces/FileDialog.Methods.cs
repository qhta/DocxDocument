using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface FileDialog
{
  public int Show();
  public void Execute();
}
