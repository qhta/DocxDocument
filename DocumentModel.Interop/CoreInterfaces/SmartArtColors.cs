using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SmartArtColors: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  SmartArtColor this[object Index] { get; }
  int Count { get; }
}