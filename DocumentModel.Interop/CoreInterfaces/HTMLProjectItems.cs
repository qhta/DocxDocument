using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface HTMLProjectItems: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  HTMLProjectItem Item(ref object Index);
  int Count { get; }
  new IEnumerator GetEnumerator();
  object Parent { get; }
}