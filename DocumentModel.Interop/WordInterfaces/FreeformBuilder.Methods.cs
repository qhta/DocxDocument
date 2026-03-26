namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.freeformbuilder?view=word-pia"/>
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
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.freeformbuilder.addnodes?view=word-pia"/>
  public void AddNodes(Core.SegmentType SegmentType, Core.EditingType EditingType, float X1, float Y1, float X2, float Y2, float X3, float Y3);

  /// <summary>
  /// Converts the freeform into a shape.
  /// </summary>
  /// <param name="Anchor">The anchor range for the created shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.freeformbuilder.converttoshape?view=word-pia"/>
  public Shape ConvertToShape(object Anchor);
}
