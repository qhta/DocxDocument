using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFiles: InteropCollection<SharedWorkspaceFile>
{
  public SharedWorkspaceFile Add(string FileName, object ParentFolder, object OverwriteIfFileAlreadyExists, object KeepInSync);
  public bool ItemCountExceeded { get; }
}
