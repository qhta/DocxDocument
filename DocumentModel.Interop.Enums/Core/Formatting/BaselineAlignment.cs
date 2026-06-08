namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobaselinealignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoBaselineAlignment")]
public enum BaselineAlignment
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBaselineAlignMixed")]
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBaselineAlignBaseline")]
  Baseline = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBaselineAlignTop")]
  Top = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBaselineAlignCenter")]
  Center = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBaselineAlignFarEast50")]
  FarEast50 = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoBaselineAlignAuto")]
  Auto = 5
}
