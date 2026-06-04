namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text flow and reading order of the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreadingorder?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdReadingOrder")]
public enum ReadingOrder
{
  /// <summary>
  /// Right-to-left reading order.
  /// </summary>
  [InteropEnumValue("wdReadingOrderRtl")]
  Rtl = 0,
  /// <summary>
  /// Left-to-right reading order.
  /// </summary>
  [InteropEnumValue("wdReadingOrderLtr")]
  Ltr = 1
}
