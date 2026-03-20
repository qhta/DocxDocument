
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenode?view=office-pia
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
