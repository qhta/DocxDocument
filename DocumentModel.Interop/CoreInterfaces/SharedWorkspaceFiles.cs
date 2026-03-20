using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFiles: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  SharedWorkspaceFile this[int Index] { get; }
  int Count { get; }
  SharedWorkspaceFile Add(string FileName, object ParentFolder, object OverwriteIfFileAlreadyExists, object KeepInSync);
  bool ItemCountExceeded { get; }
}