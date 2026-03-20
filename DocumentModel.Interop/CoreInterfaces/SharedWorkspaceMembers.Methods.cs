using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceMembers
{
  public SharedWorkspaceMember Add(string Email, string DomainName, string DisplayName, object Role);
}
