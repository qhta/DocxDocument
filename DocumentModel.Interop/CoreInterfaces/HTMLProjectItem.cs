using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface HTMLProjectItem: InteropObject
{
  string Name { get; }
  bool IsOpen { get; }
  void LoadFromFile(string FileName);
  void Open(MsoHTMLProjectOpen OpenKind);
  void SaveCopyAs(string FileName);
  string Text { get; set; }
}