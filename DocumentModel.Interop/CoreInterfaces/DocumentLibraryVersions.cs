using System.Collections;

namespace DocumentModel.Interop.Core;

public interface DocumentLibraryVersions: InteropCollection<DocumentLibraryVersion>
{
  bool IsVersioningEnabled { get; }
}