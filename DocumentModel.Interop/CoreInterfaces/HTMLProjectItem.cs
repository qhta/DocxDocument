using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface HTMLProjectItem: InteropObject
{
  public string Name { get; }
  public bool IsOpen { get; }
  public void LoadFromFile(string FileName);
  public void Open(MsoHTMLProjectOpen OpenKind);
  public void SaveCopyAs(string FileName);
  public string Text { get; set; }
}
