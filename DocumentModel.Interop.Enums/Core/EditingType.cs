namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the editing type of a node.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoeditingtype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoEditingType")]
public enum EditingType
{
  /// <summary>
  /// Editing type is appropriate to the segments being connected.
  /// </summary>
  [InteropEnumValue("msoEditingAuto")]
  Auto,
  /// <summary>
  /// Corner node.
  /// </summary>
  [InteropEnumValue("msoEditingCorner")]
  Corner,
  /// <summary>
  /// Smooth node.
  /// </summary>
  [InteropEnumValue("msoEditingSmooth")]
  Smooth,
  /// <summary>
  /// Symmetric node.
  /// </summary>
  [InteropEnumValue("msoEditingSymmetric")]
  Symmetric
}
