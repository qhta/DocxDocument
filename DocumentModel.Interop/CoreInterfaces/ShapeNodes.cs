using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ShapeNodes: InteropDictionary<string, ShapeNode>
{
  public ShapeNode Item(object Index);
  public void Delete(int Index);

  public void Insert
  (int Index, MsoSegmentType SegmentType, MsoEditingType EditingType, float X1, float Y1, float X2,
    float Y2, float X3, float Y3);

  public void SetEditingType(int Index, MsoEditingType EditingType);
  public void SetPosition(int Index, float X1, float Y1);
  public void SetSegmentType(int Index, MsoSegmentType SegmentType);
}
