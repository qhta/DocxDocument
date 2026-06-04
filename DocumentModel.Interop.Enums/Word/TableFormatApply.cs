namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how table formatting should be applied.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtableformatapply?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdTableFormatApply")]
public enum TableFormatApply
{
  /// <summary>
  /// Borders.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatApplyBorders")]
  Borders = 1,
  /// <summary>
  /// Shading.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatApplyShading")]
  Shading = 2,
  /// <summary>
  /// Font.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatApplyFont")]
  Font = 4,
  /// <summary>
  /// Color.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatApplyColor")]
  Color = 8,
  /// <summary>
  /// AutoFit.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatApplyAutoFit")]
  AutoFit = 16,
  /// <summary>
  /// Apply AutoFormat to heading rows.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatApplyHeadingRows")]
  HeadingRows = 32,
  /// <summary>
  /// Apply AutoFormat to last row.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatApplyLastRow")]
  LastRow = 64,
  /// <summary>
  /// Apply AutoFormat to first column.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatApplyFirstColumn")]
  FirstColumn = 128,
  /// <summary>
  /// Apply AutoFormat to last column.
  /// </summary>
  [WordInteropEnumValue("wdTableFormatApplyLastColumn")]
  LastColumn = 256
}
