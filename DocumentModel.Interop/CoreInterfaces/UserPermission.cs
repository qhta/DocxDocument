using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface UserPermission: InteropObject
{
  public string UserId { get; }
  public int Permission { get; set; }
  public object ExpirationDate { get; set; }
  public void Remove();
}
