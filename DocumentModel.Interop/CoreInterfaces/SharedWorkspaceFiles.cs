using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFiles: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  SharedWorkspaceFile this[int Index] { get; }
  int Count { get; }
  SharedWorkspaceFile Add(string FileName, object ParentFolder, object OverwriteIfFileAlreadyExists, object KeepInSync);
  object Parent { get; }
  bool ItemCountExceeded { get; }
}