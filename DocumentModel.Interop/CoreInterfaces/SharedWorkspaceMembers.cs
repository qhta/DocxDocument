using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceMembers: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  SharedWorkspaceMember this[int Index] { get; }
  int Count { get; }
  SharedWorkspaceMember Add(string Email, string DomainName, string DisplayName, object Role);
  bool ItemCountExceeded { get; }
}