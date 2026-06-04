namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the document element to display in the print layout view.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdseekview?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSeekView))]
public enum SeekView
{
  /// <summary>
  /// The main document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeekView.wdSeekMainDocument))]
  MainDocument = 0,
  /// <summary>
  /// The primary header.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeekView.wdSeekPrimaryHeader))]
  PrimaryHeader = 1,
  /// <summary>
  /// The first page header.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeekView.wdSeekFirstPageHeader))]
  FirstPageHeader = 2,
  /// <summary>
  /// The even pages header.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeekView.wdSeekEvenPagesHeader))]
  EvenPagesHeader = 3,
  /// <summary>
  /// The primary footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeekView.wdSeekPrimaryFooter))]
  PrimaryFooter = 4,
  /// <summary>
  /// The first page footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeekView.wdSeekFirstPageFooter))]
  FirstPageFooter = 5,
  /// <summary>
  /// The even pages footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeekView.wdSeekEvenPagesFooter))]
  EvenPagesFooter = 6,
  /// <summary>
  /// Footnotes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeekView.wdSeekFootnotes))]
  Footnotes = 7,
  /// <summary>
  /// Endnotes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeekView.wdSeekEndnotes))]
  Endnotes = 8,
  /// <summary>
  /// The current page header.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeekView.wdSeekCurrentPageHeader))]
  CurrentPageHeader = 9,
  /// <summary>
  /// The current page footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSeekView.wdSeekCurrentPageFooter))]
  CurrentPageFooter = 10
}
