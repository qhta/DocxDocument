using System.Collections;

namespace DocumentModel.Interop.Core;

public interface BalloonLabels: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  string Name { get; }
  object Parent { get; }
  object this[int Index] { get; }
  int Count { get; set; }
  new IEnumerator GetEnumerator();
}