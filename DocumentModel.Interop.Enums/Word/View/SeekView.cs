namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document element to display in the print layout view.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdseekview?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSeekView")]
public enum SeekView
{
  /// <summary>
  /// The main document.
  /// </summary>
  [InteropEnumValue("wdSeekMainDocument")]
  MainDocument = 0,
  /// <summary>
  /// The primary header.
  /// </summary>
  [InteropEnumValue("wdSeekPrimaryHeader")]
  PrimaryHeader = 1,
  /// <summary>
  /// The first page header.
  /// </summary>
  [InteropEnumValue("wdSeekFirstPageHeader")]
  FirstPageHeader = 2,
  /// <summary>
  /// The even pages header.
  /// </summary>
  [InteropEnumValue("wdSeekEvenPagesHeader")]
  EvenPagesHeader = 3,
  /// <summary>
  /// The primary footer.
  /// </summary>
  [InteropEnumValue("wdSeekPrimaryFooter")]
  PrimaryFooter = 4,
  /// <summary>
  /// The first page footer.
  /// </summary>
  [InteropEnumValue("wdSeekFirstPageFooter")]
  FirstPageFooter = 5,
  /// <summary>
  /// The even pages footer.
  /// </summary>
  [InteropEnumValue("wdSeekEvenPagesFooter")]
  EvenPagesFooter = 6,
  /// <summary>
  /// Footnotes.
  /// </summary>
  [InteropEnumValue("wdSeekFootnotes")]
  Footnotes = 7,
  /// <summary>
  /// Endnotes.
  /// </summary>
  [InteropEnumValue("wdSeekEndnotes")]
  Endnotes = 8,
  /// <summary>
  /// The current page header.
  /// </summary>
  [InteropEnumValue("wdSeekCurrentPageHeader")]
  CurrentPageHeader = 9,
  /// <summary>
  /// The current page footer.
  /// </summary>
  [InteropEnumValue("wdSeekCurrentPageFooter")]
  CurrentPageFooter = 10
}
