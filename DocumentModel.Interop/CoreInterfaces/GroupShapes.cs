using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface GroupShapes: InteropDictionary<string, Shape>
{
  public Shape Item(object Index);
  public ShapeRange Range(object Index);
}
