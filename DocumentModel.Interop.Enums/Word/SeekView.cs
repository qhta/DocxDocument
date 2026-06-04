namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document element to display in the print layout view.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdseekview?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSeekView")]
public enum SeekView
{
  /// <summary>
  /// The main document.
  /// </summary>
  [WordInteropEnumValue("wdSeekMainDocument")]
  MainDocument = 0,
  /// <summary>
  /// The primary header.
  /// </summary>
  [WordInteropEnumValue("wdSeekPrimaryHeader")]
  PrimaryHeader = 1,
  /// <summary>
  /// The first page header.
  /// </summary>
  [WordInteropEnumValue("wdSeekFirstPageHeader")]
  FirstPageHeader = 2,
  /// <summary>
  /// The even pages header.
  /// </summary>
  [WordInteropEnumValue("wdSeekEvenPagesHeader")]
  EvenPagesHeader = 3,
  /// <summary>
  /// The primary footer.
  /// </summary>
  [WordInteropEnumValue("wdSeekPrimaryFooter")]
  PrimaryFooter = 4,
  /// <summary>
  /// The first page footer.
  /// </summary>
  [WordInteropEnumValue("wdSeekFirstPageFooter")]
  FirstPageFooter = 5,
  /// <summary>
  /// The even pages footer.
  /// </summary>
  [WordInteropEnumValue("wdSeekEvenPagesFooter")]
  EvenPagesFooter = 6,
  /// <summary>
  /// Footnotes.
  /// </summary>
  [WordInteropEnumValue("wdSeekFootnotes")]
  Footnotes = 7,
  /// <summary>
  /// Endnotes.
  /// </summary>
  [WordInteropEnumValue("wdSeekEndnotes")]
  Endnotes = 8,
  /// <summary>
  /// The current page header.
  /// </summary>
  [WordInteropEnumValue("wdSeekCurrentPageHeader")]
  CurrentPageHeader = 9,
  /// <summary>
  /// The current page footer.
  /// </summary>
  [WordInteropEnumValue("wdSeekCurrentPageFooter")]
  CurrentPageFooter = 10
}
