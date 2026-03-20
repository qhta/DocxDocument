using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface TabStops2
{
  public TabStop2 Item(object Index);
  public TabStop2 Add(MsoTabStopType Type, float Position);
}
