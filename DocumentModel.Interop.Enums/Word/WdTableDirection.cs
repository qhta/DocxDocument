namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction in which Microsoft Word orders cells in the specified table or row.
/// </summary>
public enum WdTableDirection
{
  /// <summary>
  /// Specifies the direction in which Microsoft Word orders cells in the specified table or row.
  /// </summary>
  Rtl = unchecked((int)0),
  /// <summary>
  /// The selected rows are arranged with the first column in the leftmost position.
  /// </summary>
  Ltr = unchecked((int)1)
}
