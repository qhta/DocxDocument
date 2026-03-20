using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ShapeNodes: InteropDictionary<string, ShapeNode>
{
  ShapeNode Item(object Index);
  void Delete(int Index);

  void Insert
  (int Index, MsoSegmentType SegmentType, MsoEditingType EditingType, float X1, float Y1, float X2,
    float Y2, float X3, float Y3);

  void SetEditingType(int Index, MsoEditingType EditingType);
  void SetPosition(int Index, float X1, float Y1);
  void SetSegmentType(int Index, MsoSegmentType SegmentType);
}