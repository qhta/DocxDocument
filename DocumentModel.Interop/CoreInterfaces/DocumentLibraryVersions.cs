using System.Collections;

namespace DocumentModel.Interop.Core;

public interface DocumentLibraryVersions: InteropCollection<DocumentLibraryVersion>
{
  public bool IsVersioningEnabled { get; }
}
