using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface Permission
{
  public UserPermission Add(string UserId, object Permission, object ExpirationDate);
  public void ApplyPolicy(string FileName);
  public void RemoveAll();
}
