using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceMembers: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  SharedWorkspaceMember this[int Index] { get; }
  int Count { get; }
  SharedWorkspaceMember Add(string Email, string DomainName, string DisplayName, object Role);
  object Parent { get; }
  bool ItemCountExceeded { get; }
}