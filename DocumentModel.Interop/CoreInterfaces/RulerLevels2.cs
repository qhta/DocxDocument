using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface RulerLevels2: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  RulerLevel2 Item(object Index);
  new IEnumerator GetEnumerator();
}