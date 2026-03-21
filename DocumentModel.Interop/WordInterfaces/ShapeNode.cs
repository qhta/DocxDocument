namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the geometry and the geometry-editing properties of the nodes in a user-defined freeform.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenode?view=word-pia"/>
public interface ShapeNode : InteropObject
{
  /// <summary>
  /// Returns the editing type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenode.editingtype?view=word-pia"/>
  public Core.MsoEditingType EditingType { get; }
  /// <summary>
  /// Returns the points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenode.points?view=word-pia"/>
  public object Points { get; }
  /// <summary>
  /// Returns the segment type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenode.segmenttype?view=word-pia"/>
  public Core.MsoSegmentType SegmentType { get; }

}
