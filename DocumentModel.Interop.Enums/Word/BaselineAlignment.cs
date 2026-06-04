namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the vertical position of fonts on a line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbaselinealignment?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdBaselineAlignment))]
public enum BaselineAlignment
{
  /// <summary>
  /// Align along top of each font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBaselineAlignment.wdBaselineAlignTop))]
  Top = 0,
  /// <summary>
  /// Align center points of each font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBaselineAlignment.wdBaselineAlignCenter))]
  Center = 1,
  /// <summary>
  /// Align along top of each font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBaselineAlignment.wdBaselineAlignBaseline))]
  Baseline = 2,
  /// <summary>
  /// Align using Far East font standards.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBaselineAlignment.wdBaselineAlignFarEast50))]
  FarEast50 = 3,
  /// <summary>
  /// Word automatically adjusts the baseline font alignment.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBaselineAlignment.wdBaselineAlignAuto))]
  Auto = 4
}
