using System.Collections;

namespace DocumentModel.Interop.Core;

public interface FoundFiles: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  string this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}