namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies type of break.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbreaktype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdBreakType")]
public enum BreakType
{
  /// <summary>
  /// Section break on next page.
  /// </summary>
  [WordInteropEnumValue("wdSectionBreakNextPage")]
  SectionBreakNextPage = 2,
  /// <summary>
  /// New section without a corresponding page break.
  /// </summary>
  [WordInteropEnumValue("wdSectionBreakContinuous")]
  SectionBreakContinuous = 3,
  /// <summary>
  /// Section break with the next section beginning on the next even- numbered page. If the section break falls on
  /// an even-numbered page, Word leaves the next odd-numbered page blank.
  /// </summary>
  [WordInteropEnumValue("wdSectionBreakEvenPage")]
  SectionBreakEvenPage = 4,
  /// <summary>
  /// Section break with the next section beginning on the next odd- numbered page. If the section break falls on an
  /// odd-numbered page, Word leaves the next even-numbered page blank.
  /// </summary>
  [WordInteropEnumValue("wdSectionBreakOddPage")]
  SectionBreakOddPage = 5,
  /// <summary>
  /// Line break.
  /// </summary>
  [WordInteropEnumValue("wdLineBreak")]
  LineBreak = 6,
  /// <summary>
  /// Page break at the insertion point.
  /// </summary>
  [WordInteropEnumValue("wdPageBreak")]
  PageBreak = 7,
  /// <summary>
  /// Column break at the insertion point.
  /// </summary>
  [WordInteropEnumValue("wdColumnBreak")]
  ColumnBreak = 8,
  /// <summary>
  /// Line break.
  /// </summary>
  [WordInteropEnumValue("wdLineBreakClearLeft")]
  LineBreakClearLeft = 9,
  /// <summary>
  /// Line break.
  /// </summary>
  [WordInteropEnumValue("wdLineBreakClearRight")]
  LineBreakClearRight = 10,
  /// <summary>
  /// Ends the current line and forces the text to continue below a picture, table, or other item. The text
  /// continues on the next blank line that does not contain a table aligned with the left or right margin.
  /// </summary>
  [WordInteropEnumValue("wdTextWrappingBreak")]
  TextWrappingBreak = 11
}
