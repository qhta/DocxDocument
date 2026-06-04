namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the reading order for the specified object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlreadingorder?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlReadingOrder")]
public enum XlReadingOrder
{
  /// <summary>
  /// Right-to-left.
  /// </summary>
  [InteropEnumValue("xlRTL")]
  RTL = -5004,
  /// <summary>
  /// Left-to-right.
  /// </summary>
  [InteropEnumValue("xlLTR")]
  LTR = -5003,
  /// <summary>
  /// According to context.
  /// </summary>
  [InteropEnumValue("xlContext")]
  Context = -5002
}
