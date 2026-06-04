namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the editing type of a node.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoeditingtype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoEditingType")]
public enum EditingType
{
  /// <summary>
  /// Editing type is appropriate to the segments being connected.
  /// </summary>
  [OfficeInteropEnumValue("msoEditingAuto")]
  Auto,
  /// <summary>
  /// Corner node.
  /// </summary>
  [OfficeInteropEnumValue("msoEditingCorner")]
  Corner,
  /// <summary>
  /// Smooth node.
  /// </summary>
  [OfficeInteropEnumValue("msoEditingSmooth")]
  Smooth,
  /// <summary>
  /// Symmetric node.
  /// </summary>
  [OfficeInteropEnumValue("msoEditingSymmetric")]
  Symmetric
}
