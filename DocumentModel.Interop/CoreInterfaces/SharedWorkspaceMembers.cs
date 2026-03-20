using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceMembers: InteropCollection<SharedWorkspaceMember>
{
  SharedWorkspaceMember Add(string Email, string DomainName, string DisplayName, object Role);
  bool ItemCountExceeded { get; }
}