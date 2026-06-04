namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies type of break.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbreaktype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdBreakType")]
public enum BreakType
{
  /// <summary>
  /// Section break on next page.
  /// </summary>
  [InteropEnumValue("wdSectionBreakNextPage")]
  SectionBreakNextPage = 2,
  /// <summary>
  /// New section without a corresponding page break.
  /// </summary>
  [InteropEnumValue("wdSectionBreakContinuous")]
  SectionBreakContinuous = 3,
  /// <summary>
  /// Section break with the next section beginning on the next even- numbered page. If the section break falls on
  /// an even-numbered page, Word leaves the next odd-numbered page blank.
  /// </summary>
  [InteropEnumValue("wdSectionBreakEvenPage")]
  SectionBreakEvenPage = 4,
  /// <summary>
  /// Section break with the next section beginning on the next odd- numbered page. If the section break falls on an
  /// odd-numbered page, Word leaves the next even-numbered page blank.
  /// </summary>
  [InteropEnumValue("wdSectionBreakOddPage")]
  SectionBreakOddPage = 5,
  /// <summary>
  /// Line break.
  /// </summary>
  [InteropEnumValue("wdLineBreak")]
  LineBreak = 6,
  /// <summary>
  /// Page break at the insertion point.
  /// </summary>
  [InteropEnumValue("wdPageBreak")]
  PageBreak = 7,
  /// <summary>
  /// Column break at the insertion point.
  /// </summary>
  [InteropEnumValue("wdColumnBreak")]
  ColumnBreak = 8,
  /// <summary>
  /// Line break.
  /// </summary>
  [InteropEnumValue("wdLineBreakClearLeft")]
  LineBreakClearLeft = 9,
  /// <summary>
  /// Line break.
  /// </summary>
  [InteropEnumValue("wdLineBreakClearRight")]
  LineBreakClearRight = 10,
  /// <summary>
  /// Ends the current line and forces the text to continue below a picture, table, or other item. The text
  /// continues on the next blank line that does not contain a table aligned with the left or right margin.
  /// </summary>
  [InteropEnumValue("wdTextWrappingBreak")]
  TextWrappingBreak = 11
}
