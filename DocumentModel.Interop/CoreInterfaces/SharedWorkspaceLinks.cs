using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceLinks: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  SharedWorkspaceLink this[int Index] { get; }
  int Count { get; }
  SharedWorkspaceLink Add(string URL, object Description, object Notes);
  bool ItemCountExceeded { get; }
}