using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SmartArtLayouts: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  SmartArtLayout this[object Index] { get; }
  int Count { get; }
}