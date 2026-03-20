
namespace DocumentModel.Interop.Core;

public partial interface ShapeNode: InteropObject
{
  public MsoEditingType EditingType { get; }
  public object Points { get; }
  public MsoSegmentType SegmentType { get; }
}
