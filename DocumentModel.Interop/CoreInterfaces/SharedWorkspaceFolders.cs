using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFolders: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  SharedWorkspaceFolder this[int Index] { get; }
  int Count { get; }
  SharedWorkspaceFolder Add(string FolderName, object ParentFolder);
  object Parent { get; }
  bool ItemCountExceeded { get; }
}