using System.Collections;

namespace DocumentModel.Interop.Core;

public interface DocumentLibraryVersions: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  DocumentLibraryVersion this[int lIndex] { get; }
  int Count { get; }
  object Parent { get; }
  bool IsVersioningEnabled { get; }
  new IEnumerator GetEnumerator();
}