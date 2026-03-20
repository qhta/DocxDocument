using System.Collections;

namespace DocumentModel.Interop.Core;

public interface DocumentLibraryVersions: InteropObject, IEnumerable
{
  DocumentLibraryVersion this[int lIndex] { get; }
  int Count { get; }
  bool IsVersioningEnabled { get; }
  new IEnumerator GetEnumerator();
}