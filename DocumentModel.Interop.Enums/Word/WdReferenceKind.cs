namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the information to include in a cross-reference.
/// </summary>
public enum WdReferenceKind
{
  /// <summary>
  /// Insert label, number, and any additional caption of specified equation, figure, or table.
  /// wdOnlyLabelAndNumber3 Insert only the label and number of the specified equation, figure, or table.
  /// </summary>
  wdEntireCaption = unchecked((int)2),
  /// <summary>
  /// Specifies the information to include in a cross-reference.
  /// </summary>
  wdOnlyLabelAndNumber = unchecked((int)3),
  /// <summary>
  /// Insert only the caption text of the specified equation, figure, or table.
  /// </summary>
  wdOnlyCaptionText = unchecked((int)4),
  /// <summary>
  /// Insert footnote reference mark. [System.Runtime.InteropServices.Guid("394033AF-E0BA-30E7-B099-A79873E55634")]
  /// public enum WdReferenceKind ﾉ Expand table
  /// </summary>
  wdFootnoteNumber = unchecked((int)5),
  /// <summary>
  /// Insert endnote reference mark.
  /// </summary>
  wdEndnoteNumber = unchecked((int)6),
  /// <summary>
  /// Insert page number of specified item.
  /// </summary>
  wdPageNumber = unchecked((int)7),
  /// <summary>
  /// Insert the word "Above" or the word "Below" as appropriate. wdFootnoteNumberFormatted16 Insert formatted
  /// footnote reference mark. wdEndnoteNumberFormatted17 Insert formatted endnote reference mark.
  /// </summary>
  wdPosition = unchecked((int)15),
  /// <summary>
  /// Specifies the information to include in a cross-reference.
  /// </summary>
  wdFootnoteNumberFormatted = unchecked((int)16),
  /// <summary>
  /// Specifies the information to include in a cross-reference.
  /// </summary>
  wdEndnoteNumberFormatted = unchecked((int)17),
  /// <summary>
  /// Specifies the information to include in a cross-reference.
  /// </summary>
  wdNumberFullContext = unchecked((int)-4),
  /// <summary>
  /// Specifies the information to include in a cross-reference.
  /// </summary>
  wdNumberNoContext = unchecked((int)-3),
  /// <summary>
  /// Specifies the information to include in a cross-reference.
  /// </summary>
  wdNumberRelativeContext = unchecked((int)-2),
  /// <summary>
  /// Specifies the information to include in a cross-reference.
  /// </summary>
  wdContentText = unchecked((int)-1)
}
