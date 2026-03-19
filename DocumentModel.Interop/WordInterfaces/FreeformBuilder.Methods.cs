namespace DocumentModel.Interop.Word;

public partial interface FreeformBuilder
{
  /// <summary>
  /// Adds a node to the freeform being built.
  /// </summary>
  /// <param name="SegmentType">The segment type used for the new node.</param>
  /// <param name="EditingType">The editing type used for the new node.</param>
  /// <param name="X1">The x-coordinate, in points, of the first point.</param>
  /// <param name="Y1">The y-coordinate, in points, of the first point.</param>
  /// <param name="X2">The x-coordinate, in points, of the second point (used for curved segments).</param>
  /// <param name="Y2">The y-coordinate, in points, of the second point (used for curved segments).</param>
  /// <param name="X3">The x-coordinate, in points, of the third point (used for curved segments).</param>
  /// <param name="Y3">The y-coordinate, in points, of the third point (used for curved segments).</param>
  public void AddNodes(Core.MsoSegmentType SegmentType, Core.MsoEditingType EditingType, float X1, float Y1, float X2, float Y2, float X3, float Y3);

  /// <summary>
  /// Converts the freeform into a shape.
  /// </summary>
  /// <param name="Anchor">The anchor range for the created shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  public Shape ConvertToShape(object Anchor);
}
