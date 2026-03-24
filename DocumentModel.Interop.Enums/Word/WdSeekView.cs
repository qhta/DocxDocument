namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document element to display in the print layout view.
/// </summary>
public enum WdSeekView
{
  /// <summary>
  /// The main document.
  /// </summary>
  MainDocument = unchecked((int)0),
  /// <summary>
  /// The primary header.
  /// </summary>
  PrimaryHeader = unchecked((int)1),
  /// <summary>
  /// The first page header.
  /// </summary>
  FirstPageHeader = unchecked((int)2),
  /// <summary>
  /// The even pages header.
  /// </summary>
  EvenPagesHeader = unchecked((int)3),
  /// <summary>
  /// The primary footer.
  /// </summary>
  PrimaryFooter = unchecked((int)4),
  /// <summary>
  /// The first page footer.
  /// </summary>
  FirstPageFooter = unchecked((int)5),
  /// <summary>
  /// The even pages footer.
  /// </summary>
  EvenPagesFooter = unchecked((int)6),
  /// <summary>
  /// Footnotes.
  /// </summary>
  Footnotes = unchecked((int)7),
  /// <summary>
  /// Endnotes.
  /// </summary>
  Endnotes = unchecked((int)8),
  /// <summary>
  /// The current page header.
  /// </summary>
  CurrentPageHeader = unchecked((int)9),
  /// <summary>
  /// The current page footer. [System.Runtime.InteropServices.Guid("8472D0A9-03EA-3253-8BC8-F66718CF09A6")] public
  /// enum WdSeekView ﾉ Expand table
  /// </summary>
  CurrentPageFooter = unchecked((int)10)
}
