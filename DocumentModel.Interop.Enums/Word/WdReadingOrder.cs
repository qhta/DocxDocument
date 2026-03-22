namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the text flow and reading order of the document.
/// </summary>
public enum WdReadingOrder
{
  /// <summary>
  /// Right-to-left reading order.
  /// </summary>
  wdReadingOrderRtl = unchecked((int)0),
  /// <summary>
  /// Left-to-right reading order.
  /// </summary>
  wdReadingOrderLtr = unchecked((int)1)
}
