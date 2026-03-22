namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document element to display in the print layout view.
/// </summary>
public enum WdSeekView
{
  /// <summary>
  /// The main document.
  /// </summary>
  wdSeekMainDocument = unchecked((int)0),
  /// <summary>
  /// The primary header.
  /// </summary>
  wdSeekPrimaryHeader = unchecked((int)1),
  /// <summary>
  /// The first page header.
  /// </summary>
  wdSeekFirstPageHeader = unchecked((int)2),
  /// <summary>
  /// The even pages header.
  /// </summary>
  wdSeekEvenPagesHeader = unchecked((int)3),
  /// <summary>
  /// The primary footer.
  /// </summary>
  wdSeekPrimaryFooter = unchecked((int)4),
  /// <summary>
  /// The first page footer.
  /// </summary>
  wdSeekFirstPageFooter = unchecked((int)5),
  /// <summary>
  /// The even pages footer.
  /// </summary>
  wdSeekEvenPagesFooter = unchecked((int)6),
  /// <summary>
  /// Footnotes.
  /// </summary>
  wdSeekFootnotes = unchecked((int)7),
  /// <summary>
  /// Endnotes.
  /// </summary>
  wdSeekEndnotes = unchecked((int)8),
  /// <summary>
  /// The current page header.
  /// </summary>
  wdSeekCurrentPageHeader = unchecked((int)9),
  /// <summary>
  /// The current page footer. [System.Runtime.InteropServices.Guid("8472D0A9-03EA-3253-8BC8-F66718CF09A6")] public
  /// enum WdSeekView ﾉ Expand table
  /// </summary>
  wdSeekCurrentPageFooter = unchecked((int)10)
}
