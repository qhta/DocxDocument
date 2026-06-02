
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenode?view=office-pia"/>
public partial interface IShapeNode: IInteropObject
{
  /// <summary>
  /// Gets the `EditingType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenode.editingtype?view=office-pia"/>
  public EditingType EditingType { get; }
  /// <summary>
  /// Gets the `Points` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenode.points?view=office-pia"/>
  public object Points { get; }
  /// <summary>
  /// Gets the `SegmentType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenode.segmenttype?view=office-pia"/>
  public SegmentType SegmentType { get; }
}

