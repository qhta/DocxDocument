using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface RulerLevels2: InteropObject, IEnumerable
{
  int Count { get; }
  RulerLevel2 Item(object Index);
  new IEnumerator GetEnumerator();
}