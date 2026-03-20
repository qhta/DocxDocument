using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface GroupShapes: InteropObject, IEnumerable
{
  int Count { get; }
  Shape Item(object Index);
  new IEnumerator GetEnumerator();
  ShapeRange Range(object Index);
}