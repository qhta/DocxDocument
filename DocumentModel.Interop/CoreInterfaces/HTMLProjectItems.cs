using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface HTMLProjectItems: InteropObject, IEnumerable
{
  HTMLProjectItem Item(ref object Index);
  int Count { get; }
  new IEnumerator GetEnumerator();
}