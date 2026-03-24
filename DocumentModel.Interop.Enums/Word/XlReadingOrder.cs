namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the reading order for the specified object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlreadingorder?view=office-pia` for Office interop details.
/// </remarks>
public enum XlReadingOrder
{
  /// <summary>
  /// Specifies the reading order for the specified object.
  /// </summary>
  RTL = -5004,
  /// <summary>
  /// Specifies the reading order for the specified object.
  /// </summary>
  LTR = -5003,
  /// <summary>
  /// Specifies the reading order for the specified object.
  /// </summary>
  Context = -5002
}
