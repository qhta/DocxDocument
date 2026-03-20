
namespace DocumentModel.Interop.Core;

public interface FreeformBuilder: InteropObject
{
  void AddNodes
  (MsoSegmentType SegmentType, MsoEditingType EditingType, float X1, float Y1, float X2, float Y2,
    float X3, float Y3);

  Shape ConvertToShape();
}