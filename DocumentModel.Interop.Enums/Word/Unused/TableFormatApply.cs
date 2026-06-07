namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how table formatting should be applied.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableformatapply?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTableFormatApply")]
public enum TableFormatApply
{
  /// <summary>
  /// Borders.
  /// </summary>
  [InteropEnumValue("wdTableFormatApplyBorders")]
  Borders = 1,
  /// <summary>
  /// Shading.
  /// </summary>
  [InteropEnumValue("wdTableFormatApplyShading")]
  Shading = 2,
  /// <summary>
  /// Font.
  /// </summary>
  [InteropEnumValue("wdTableFormatApplyFont")]
  Font = 4,
  /// <summary>
  /// Color.
  /// </summary>
  [InteropEnumValue("wdTableFormatApplyColor")]
  Color = 8,
  /// <summary>
  /// AutoFit.
  /// </summary>
  [InteropEnumValue("wdTableFormatApplyAutoFit")]
  AutoFit = 16,
  /// <summary>
  /// Apply AutoFormat to heading rows.
  /// </summary>
  [InteropEnumValue("wdTableFormatApplyHeadingRows")]
  HeadingRows = 32,
  /// <summary>
  /// Apply AutoFormat to last row.
  /// </summary>
  [InteropEnumValue("wdTableFormatApplyLastRow")]
  LastRow = 64,
  /// <summary>
  /// Apply AutoFormat to first column.
  /// </summary>
  [InteropEnumValue("wdTableFormatApplyFirstColumn")]
  FirstColumn = 128,
  /// <summary>
  /// Apply AutoFormat to last column.
  /// </summary>
  [InteropEnumValue("wdTableFormatApplyLastColumn")]
  LastColumn = 256
}
