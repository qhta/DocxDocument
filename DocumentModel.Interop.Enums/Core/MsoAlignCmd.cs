namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines how to align specified objects relative to one another.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoaligncmd?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoAlignCmd")]
public enum AlignCmd
{
  /// <summary>
  /// Align left sides of specified objects.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignLefts")]
  Lefts,
  /// <summary>
  /// Align centers of specified objects.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignCenters")]
  Centers,
  /// <summary>
  /// Align right sides of specified objects.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignRights")]
  Rights,
  /// <summary>
  /// Align tops of specified objects.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignTops")]
  Tops,
  /// <summary>
  /// Align middles of specified objects.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignMiddles")]
  Middles,
  /// <summary>
  /// Align bottoms of specified objects.
  /// </summary>
  [OfficeInteropEnumValue("msoAlignBottoms")]
  Bottoms
}
