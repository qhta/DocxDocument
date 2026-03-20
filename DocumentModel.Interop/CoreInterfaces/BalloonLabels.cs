using System.Collections;

namespace DocumentModel.Interop.Core;

public interface BalloonLabels: InteropObject, IEnumerable
{
  string Name { get; }
  object this[int Index] { get; }
  int Count { get; set; }
  new IEnumerator GetEnumerator();
}