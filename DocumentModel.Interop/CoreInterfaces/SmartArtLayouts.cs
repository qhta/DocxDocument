using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SmartArtLayouts: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  SmartArtLayout this[object Index] { get; }
  object Parent { get; }
  int Count { get; }
}