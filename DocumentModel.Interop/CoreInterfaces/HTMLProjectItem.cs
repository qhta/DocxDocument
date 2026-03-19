using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface HTMLProjectItem: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Name { get; }
  bool IsOpen { get; }
  void LoadFromFile(string FileName);
  void Open(MsoHTMLProjectOpen OpenKind = (MsoHTMLProjectOpen)0);
  void SaveCopyAs(string FileName);
  string Text { get; set; }
  object Parent { get; }
}