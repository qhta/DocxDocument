using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SmartArtColors: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  SmartArtColor this[object Index] { get; }
  object Parent { get; }
  int Count { get; }
}