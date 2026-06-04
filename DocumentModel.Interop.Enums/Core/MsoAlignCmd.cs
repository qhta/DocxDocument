namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines how to align specified objects relative to one another.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoaligncmd?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoAlignCmd))]
public enum AlignCmd
{
  /// <summary>
  /// Align left sides of specified objects.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlignCmd.msoAlignLefts))]
  Lefts,
  /// <summary>
  /// Align centers of specified objects.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlignCmd.msoAlignCenters))]
  Centers,
  /// <summary>
  /// Align right sides of specified objects.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlignCmd.msoAlignRights))]
  Rights,
  /// <summary>
  /// Align tops of specified objects.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlignCmd.msoAlignTops))]
  Tops,
  /// <summary>
  /// Align middles of specified objects.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlignCmd.msoAlignMiddles))]
  Middles,
  /// <summary>
  /// Align bottoms of specified objects.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoAlignCmd.msoAlignBottoms))]
  Bottoms
}
