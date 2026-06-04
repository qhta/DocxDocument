namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobaselinealignment?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoBaselineAlignment")]
public enum BaselineAlignment
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBaselineAlignMixed")]
  Mixed = -2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBaselineAlignBaseline")]
  Baseline = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBaselineAlignTop")]
  Top = 2,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBaselineAlignCenter")]
  Center = 3,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBaselineAlignFarEast50")]
  FarEast50 = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoBaselineAlignAuto")]
  Auto = 5
}
