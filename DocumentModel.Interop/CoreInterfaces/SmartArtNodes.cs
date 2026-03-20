using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SmartArtNodes: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  SmartArtNode this[object Index] { get; }
  int Count { get; }
  SmartArtNode Add();
}