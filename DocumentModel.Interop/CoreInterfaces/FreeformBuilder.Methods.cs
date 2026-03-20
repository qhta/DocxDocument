
namespace DocumentModel.Interop.Core;

public partial interface FreeformBuilder
{
  public void AddNodes
  (MsoSegmentType SegmentType, MsoEditingType EditingType, float X1, float Y1, float X2, float Y2,
    float X3, float Y3);
  public Shape ConvertToShape();
}
