using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface HTMLProject
{
  public void RefreshProject(bool Refresh);
  public void RefreshDocument(bool Refresh);
  public void Open(MsoHTMLProjectOpen OpenKind);
}
