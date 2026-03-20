using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface DocumentLibraryVersions: InteropCollection<DocumentLibraryVersion>
{
  public bool IsVersioningEnabled { get; }
}
