using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface GroupShapes
{
  public Shape Item(object Index);
  public ShapeRange Range(object Index);
}
