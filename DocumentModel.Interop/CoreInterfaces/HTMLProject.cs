using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface HTMLProject: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  MsoHTMLProjectState State { get; }
  void RefreshProject(bool Refresh = true);
  void RefreshDocument(bool Refresh = true);
  HTMLProjectItems HTMLProjectItems { get; }
  object Parent { get; }
  void Open(MsoHTMLProjectOpen OpenKind = (MsoHTMLProjectOpen)0);
}