namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the reading order for the specified object.
/// </summary>
public enum XlReadingOrder
{
  /// <summary>
  /// Specifies the reading order for the specified object.
  /// </summary>
  xlRTL = unchecked((int)-5004),
  /// <summary>
  /// Specifies the reading order for the specified object.
  /// </summary>
  xlLTR = unchecked((int)-5003),
  /// <summary>
  /// Specifies the reading order for the specified object.
  /// </summary>
  xlContext = unchecked((int)-5002)
}
