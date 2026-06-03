namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the geometry of a freeform while it's being built.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.freeformbuilder?view=word-pia"/>
public partial class FreeformBuilder : InteropObject
{


  #region methods

/// <summary>
  /// Adds a node to the freeform being built.
  /// </summary>
  /// <param name="segmentType">The segment type used for the new node.</param>
  /// <param name="editingType">The editing type used for the new node.</param>
  /// <param name="x1">The x-coordinate, in points, of the first point.</param>
  /// <param name="y1">The y-coordinate, in points, of the first point.</param>
  /// <param name="x2">The x-coordinate, in points, of the second point (used for curved segments).</param>
  /// <param name="y2">The y-coordinate, in points, of the second point (used for curved segments).</param>
  /// <param name="x3">The x-coordinate, in points, of the third point (used for curved segments).</param>
  /// <param name="y3">The y-coordinate, in points, of the third point (used for curved segments).</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.freeformbuilder.addnodes?view=word-pia"/>
  public void AddNodes(Core.SegmentType segmentType, Core.EditingType editingType, float x1, float y1, float x2, float y2, float x3, float y3) { throw new NotImplementedException(); }

  /// <summary>
  /// Converts the freeform into a shape.
  /// </summary>
  /// <param name="anchor">The anchor range for the created shape.</param>
  /// <returns>The created <see cref="Shape"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.freeformbuilder.converttoshape?view=word-pia"/>
  public Shape ConvertToShape(object anchor) { throw new NotImplementedException(); }

  #endregion methods
}
