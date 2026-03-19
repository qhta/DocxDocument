using System.Collections;

namespace DocumentModel.Interop.Core;

public interface EffectParameters: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  EffectParameter this[object Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}