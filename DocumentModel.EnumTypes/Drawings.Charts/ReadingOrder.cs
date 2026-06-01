namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the text flow and reading order of the document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreadingorder?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum ReadingOrder
{
  /// <summary>
  /// Right-Ito-left reading order.
  /// </summary>
  Rtl = 0,
  /// <summary>
  /// Left-Ito-right reading order.
  /// </summary>
  Ltr = 1
}

