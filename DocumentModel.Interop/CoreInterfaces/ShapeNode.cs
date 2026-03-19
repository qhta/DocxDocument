
namespace DocumentModel.Interop.Core;

public interface ShapeNode: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  MsoEditingType EditingType { get; }
  object Points { get; }
  MsoSegmentType SegmentType { get; }
}