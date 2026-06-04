namespace DocumentModel.Interop.Word;

/// <summary>
/// Returns the specified header or footer in a document or section.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdheaderfooterindex?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdHeaderFooterIndex")]
public enum HeaderFooterIndex
{
  /// <summary>
  /// Returns the header or footer on all pages other than the first page of a document or section.
  /// </summary>
  [InteropEnumValue("wdHeaderFooterPrimary")]
  Primary = 1,
  /// <summary>
  /// Returns the first header or footer in a document or section.
  /// </summary>
  [InteropEnumValue("wdHeaderFooterFirstPage")]
  FirstPage = 2,
  /// <summary>
  /// Returns all headers or footers on even-numbered pages.
  /// </summary>
  [InteropEnumValue("wdHeaderFooterEvenPages")]
  EvenPages = 3
}
