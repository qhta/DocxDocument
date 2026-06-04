namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how table formatting should be applied.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableformatapply?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTableFormatApply))]
public enum TableFormatApply
{
  /// <summary>
  /// Borders.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormatApply.wdTableFormatApplyBorders))]
  Borders = 1,
  /// <summary>
  /// Shading.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormatApply.wdTableFormatApplyShading))]
  Shading = 2,
  /// <summary>
  /// Font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormatApply.wdTableFormatApplyFont))]
  Font = 4,
  /// <summary>
  /// Color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormatApply.wdTableFormatApplyColor))]
  Color = 8,
  /// <summary>
  /// AutoFit.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormatApply.wdTableFormatApplyAutoFit))]
  AutoFit = 16,
  /// <summary>
  /// Apply AutoFormat to heading rows.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormatApply.wdTableFormatApplyHeadingRows))]
  HeadingRows = 32,
  /// <summary>
  /// Apply AutoFormat to last row.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormatApply.wdTableFormatApplyLastRow))]
  LastRow = 64,
  /// <summary>
  /// Apply AutoFormat to first column.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormatApply.wdTableFormatApplyFirstColumn))]
  FirstColumn = 128,
  /// <summary>
  /// Apply AutoFormat to last column.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableFormatApply.wdTableFormatApplyLastColumn))]
  LastColumn = 256
}
