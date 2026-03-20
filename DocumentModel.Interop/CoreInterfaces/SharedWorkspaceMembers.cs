using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceMembers: InteropCollection<SharedWorkspaceMember>
{
  public SharedWorkspaceMember Add(string Email, string DomainName, string DisplayName, object Role);
  public bool ItemCountExceeded { get; }
}
