
namespace DocumentModel.Interop.Core;

public interface ShapeNode: InteropObject
{
  MsoEditingType EditingType { get; }
  object Points { get; }
  MsoSegmentType SegmentType { get; }
}