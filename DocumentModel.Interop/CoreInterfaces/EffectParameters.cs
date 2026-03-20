using System.Collections;

namespace DocumentModel.Interop.Core;

public interface EffectParameters: InteropObject, IEnumerable
{
  EffectParameter this[object Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}