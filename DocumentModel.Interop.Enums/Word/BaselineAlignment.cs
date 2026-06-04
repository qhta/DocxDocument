namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the vertical position of fonts on a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbaselinealignment?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdBaselineAlignment")]
public enum BaselineAlignment
{
  /// <summary>
  /// Align along top of each font.
  /// </summary>
  [InteropEnumValue("wdBaselineAlignTop")]
  Top = 0,
  /// <summary>
  /// Align center points of each font.
  /// </summary>
  [InteropEnumValue("wdBaselineAlignCenter")]
  Center = 1,
  /// <summary>
  /// Align along top of each font.
  /// </summary>
  [InteropEnumValue("wdBaselineAlignBaseline")]
  Baseline = 2,
  /// <summary>
  /// Align using Far East font standards.
  /// </summary>
  [InteropEnumValue("wdBaselineAlignFarEast50")]
  FarEast50 = 3,
  /// <summary>
  /// Word automatically adjusts the baseline font alignment.
  /// </summary>
  [InteropEnumValue("wdBaselineAlignAuto")]
  Auto = 4
}
