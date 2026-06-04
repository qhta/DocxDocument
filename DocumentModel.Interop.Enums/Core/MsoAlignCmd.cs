namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines how to align specified objects relative to one another.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoaligncmd?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoAlignCmd")]
public enum AlignCmd
{
  /// <summary>
  /// Align left sides of specified objects.
  /// </summary>
  [InteropEnumValue("msoAlignLefts")]
  Lefts,
  /// <summary>
  /// Align centers of specified objects.
  /// </summary>
  [InteropEnumValue("msoAlignCenters")]
  Centers,
  /// <summary>
  /// Align right sides of specified objects.
  /// </summary>
  [InteropEnumValue("msoAlignRights")]
  Rights,
  /// <summary>
  /// Align tops of specified objects.
  /// </summary>
  [InteropEnumValue("msoAlignTops")]
  Tops,
  /// <summary>
  /// Align middles of specified objects.
  /// </summary>
  [InteropEnumValue("msoAlignMiddles")]
  Middles,
  /// <summary>
  /// Align bottoms of specified objects.
  /// </summary>
  [InteropEnumValue("msoAlignBottoms")]
  Bottoms
}
