
namespace DocumentModel.Interop.Core;

public interface FreeformBuilder: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }

  void AddNodes
  (MsoSegmentType SegmentType, MsoEditingType EditingType, float X1, float Y1, float X2 = 0f, float Y2 = 0f,
    float X3 = 0f, float Y3 = 0f);

  Shape ConvertToShape();
}