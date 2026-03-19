using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface GroupShapes: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int Count { get; }
  Shape Item(object Index);
  new IEnumerator GetEnumerator();
  ShapeRange Range(object Index);
}