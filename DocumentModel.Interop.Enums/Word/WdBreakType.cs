namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies type of break.
/// </summary>
public enum WdBreakType
{
  /// <summary>
  /// Section break on next page. wdSectionBreakContinuous3 New section without a corresponding page break.
  /// </summary>
  SectionBreakNextPage = unchecked((int)2),
  /// <summary>
  /// Specifies type of break.
  /// </summary>
  SectionBreakContinuous = unchecked((int)3),
  /// <summary>
  /// Section break with the next section beginning on the next even- numbered page. If the section break falls on
  /// an even-numbered page, Word leaves the next odd-numbered page blank.
  /// </summary>
  SectionBreakEvenPage = unchecked((int)4),
  /// <summary>
  /// Section break with the next section beginning on the next odd- numbered page. If the section break falls on an
  /// odd-numbered page, Word leaves the next even-numbered page blank.
  /// </summary>
  SectionBreakOddPage = unchecked((int)5),
  /// <summary>
  /// Line break.
  /// </summary>
  LineBreak = unchecked((int)6),
  /// <summary>
  /// Page break at the insertion point.
  /// </summary>
  PageBreak = unchecked((int)7),
  /// <summary>
  /// Column break at the insertion point.
  /// </summary>
  ColumnBreak = unchecked((int)8),
  /// <summary>
  /// Line break. wdLineBreakClearRight10 Line break.
  /// [System.Runtime.InteropServices.Guid("58B14C6F-0FE6-3BCA-880E-E3A9C039E588")] public enum WdBreakType ﾉ Expand
  /// table
  /// </summary>
  LineBreakClearLeft = unchecked((int)9),
  /// <summary>
  /// Specifies type of break.
  /// </summary>
  LineBreakClearRight = unchecked((int)10),
  /// <summary>
  /// Ends the current line and forces the text to continue below a picture, table, or other item. The text
  /// continues on the next blank line that does not contain a table aligned with the left or right margin.
  /// </summary>
  TextWrappingBreak = unchecked((int)11)
}
