namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where revisions are displayed when change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisedlinesmark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRevisedLinesMark))]
public enum RevisedLinesMark
{
  /// <summary>
  /// Not displayed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedLinesMark.wdRevisedLinesMarkNone))]
  None = 0,
  /// <summary>
  /// In the left border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedLinesMark.wdRevisedLinesMarkLeftBorder))]
  LeftBorder = 1,
  /// <summary>
  /// In the right border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedLinesMark.wdRevisedLinesMarkRightBorder))]
  RightBorder = 2,
  /// <summary>
  /// Outside the border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedLinesMark.wdRevisedLinesMarkOutsideBorder))]
  OutsideBorder = 3
}
