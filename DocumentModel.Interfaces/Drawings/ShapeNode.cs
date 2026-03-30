namespace DocumentModel.Drawings;

/// <summary>
/// Represents the geometry and the geometry-editing properties of the nodes in a user-defined freeform.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenode?view=word-pia"/>
public interface ShapeNode : IModelObject
{
  /// <summary>
  /// If the specified node is a vertex, this property returns a value that indicates how changes made to the node
  /// affect the two segments connected to the node. If the node is a control point for a curved segment, this
  /// property returns the editing type of the adjacent vertex.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenode.editingtype?view=word-pia"/>
  public Drw.EditingType EditingType { get; }
  /// <summary>
  /// Returns the position of the specified node as a coordinate pair. Each coordinate is expressed in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenode.points?view=word-pia"/>
  public object Points { get; }
  /// <summary>
  /// Returns a value that indicates whether the segment associated with the specified node is straight or curved.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shapenode.segmenttype?view=word-pia"/>
  public Drw.SegmentType SegmentType { get; }

}
