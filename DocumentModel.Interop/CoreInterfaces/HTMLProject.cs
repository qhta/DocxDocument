using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface HTMLProject: InteropObject
{
  public MsoHTMLProjectState State { get; }
  public void RefreshProject(bool Refresh);
  public void RefreshDocument(bool Refresh);
  public HTMLProjectItems HTMLProjectItems { get; }
  public void Open(MsoHTMLProjectOpen OpenKind);
}
