using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFolders: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  SharedWorkspaceFolder this[int Index] { get; }
  int Count { get; }
  SharedWorkspaceFolder Add(string FolderName, object ParentFolder);
  bool ItemCountExceeded { get; }
}