using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspace
{
  public void Refresh();
  public void CreateNew(object URL, object Name);
  public void Delete();
  public void RemoveDocument();
  public void Disconnect();
}
