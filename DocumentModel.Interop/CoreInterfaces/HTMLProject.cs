using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface HTMLProject: InteropObject
{
  MsoHTMLProjectState State { get; }
  void RefreshProject(bool Refresh);
  void RefreshDocument(bool Refresh);
  HTMLProjectItems HTMLProjectItems { get; }
  void Open(MsoHTMLProjectOpen OpenKind);
}