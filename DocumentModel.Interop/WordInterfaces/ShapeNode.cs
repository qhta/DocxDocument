namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the geometry and the geometry-editing properties of the nodes in a user-defined freeform.
/// </summary>
public interface ShapeNode : InteropObject
{
  /// <summary>
  /// The editing type.
  /// </summary>
  public Core.MsoEditingType EditingType { get; }
  /// <summary>
  /// The points.
  /// </summary>
  public object Points { get; }
  /// <summary>
  /// The segment type.
  /// </summary>
  public Core.MsoSegmentType SegmentType { get; }

}
