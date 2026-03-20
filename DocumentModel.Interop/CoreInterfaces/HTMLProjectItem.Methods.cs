using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface HTMLProjectItem
{
  public void LoadFromFile(string FileName);
  public void Open(MsoHTMLProjectOpen OpenKind);
  public void SaveCopyAs(string FileName);
}
