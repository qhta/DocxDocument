using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface GroupShapes: InteropDictionary<string, Shape>
{
  Shape Item(object Index);
  ShapeRange Range(object Index);
}