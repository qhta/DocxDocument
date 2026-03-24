namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the rule for determining the height of the specified cells or rows.
/// </summary>
public enum WdRowHeightRule
{
  /// <summary>
  /// The row height is adjusted to accommodate the tallest value in the row. wdRowHeightAtLeast1 The row height is
  /// at least a minimum specified value. wdRowHeightExactly2 The row height is an exact value.
  /// </summary>
  Auto = unchecked((int)0),
  /// <summary>
  /// Specifies the rule for determining the height of the specified cells or rows.
  /// </summary>
  AtLeast = unchecked((int)1),
  /// <summary>
  /// Specifies the rule for determining the height of the specified cells or rows.
  /// </summary>
  Exactly = unchecked((int)2)
}
