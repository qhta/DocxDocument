namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the reading order for the specified object.
/// </summary>
public enum XlReadingOrder
{
  /// <summary>
  /// Specifies the reading order for the specified object.
  /// </summary>
  RTL = unchecked((int)-5004),
  /// <summary>
  /// Specifies the reading order for the specified object.
  /// </summary>
  LTR = unchecked((int)-5003),
  /// <summary>
  /// Specifies the reading order for the specified object.
  /// </summary>
  Context = unchecked((int)-5002)
}
