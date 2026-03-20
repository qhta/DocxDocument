using System.Collections;

namespace DocumentModel.Interop.Core;

public interface Permission: InteropDictionary<string, UserPermission>
{
  public bool EnableTrustedBrowser { get; set; }
  public UserPermission Add(string UserId, object Permission, object ExpirationDate);
  public void ApplyPolicy(string FileName);
  public void RemoveAll();
  public bool Enabled { get; set; }
  public string RequestPermissionURL { get; set; }
  public string PolicyName { get; }
  public string PolicyDescription { get; }
  public bool StoreLicenses { get; set; }
  public string DocumentAuthor { get; set; }
  public bool PermissionFromPolicy { get; }
}
