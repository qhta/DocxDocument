using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface Permission: InteropDictionary<string, UserPermission>
{
  public bool EnableTrustedBrowser { get; set; }
  public bool Enabled { get; set; }
  public string RequestPermissionURL { get; set; }
  public string PolicyName { get; }
  public string PolicyDescription { get; }
  public bool StoreLicenses { get; set; }
  public string DocumentAuthor { get; set; }
  public bool PermissionFromPolicy { get; }
}
