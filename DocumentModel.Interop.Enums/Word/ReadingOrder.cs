namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text flow and reading order of the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreadingorder?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdReadingOrder))]
public enum ReadingOrder
{
  /// <summary>
  /// Right-to-left reading order.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReadingOrder.wdReadingOrderRtl))]
  Rtl = 0,
  /// <summary>
  /// Left-to-right reading order.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReadingOrder.wdReadingOrderLtr))]
  Ltr = 1
}
