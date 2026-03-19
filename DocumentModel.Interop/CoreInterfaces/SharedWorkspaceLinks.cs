using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceLinks: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  SharedWorkspaceLink this[int Index] { get; }
  int Count { get; }
  SharedWorkspaceLink Add(string URL, object Description, object Notes);
  object Parent { get; }
  bool ItemCountExceeded { get; }
}