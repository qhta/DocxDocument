using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SmartArtQuickStyles: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  SmartArtQuickStyle this[object Index] { get; }
  int Count { get; }
}