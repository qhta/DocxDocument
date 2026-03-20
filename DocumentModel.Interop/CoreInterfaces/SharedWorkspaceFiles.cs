using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFiles: InteropCollection<SharedWorkspaceFile>
{
  SharedWorkspaceFile Add(string FileName, object ParentFolder, object OverwriteIfFileAlreadyExists, object KeepInSync);
  bool ItemCountExceeded { get; }
}