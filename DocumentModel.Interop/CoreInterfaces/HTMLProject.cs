using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface HTMLProject: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  MsoHTMLProjectState State { get; }
  void RefreshProject(bool Refresh);
  void RefreshDocument(bool Refresh);
  HTMLProjectItems HTMLProjectItems { get; }
  object Parent { get; }
  void Open(MsoHTMLProjectOpen OpenKind);
}