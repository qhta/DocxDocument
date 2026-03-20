
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ShapeNode` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenode?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ShapeNode: InteropObject
{
  /// <summary>
  /// Gets the `EditingType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenode.editingtype?view=office-pia
  /// </remarks>
  public MsoEditingType EditingType { get; }
  /// <summary>
  /// Gets the `Points` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenode.points?view=office-pia
  /// </remarks>
  public object Points { get; }
  /// <summary>
  /// Gets the `SegmentType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenode.segmenttype?view=office-pia
  /// </remarks>
  public MsoSegmentType SegmentType { get; }
}
