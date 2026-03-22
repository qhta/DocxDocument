namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the horizontal alignment for an equation.
/// </summary>
public enum WdOMathHorizAlignType
{
  /// <summary>
  /// Centered.
  /// </summary>
  wdOMathHorizAlignCenter = unchecked((int)0),
  /// <summary>
  /// Left alignment.
  /// </summary>
  wdOMathHorizAlignLeft = unchecked((int)1),
  /// <summary>
  /// Right alignment.
  /// </summary>
  wdOMathHorizAlignRight = unchecked((int)2)
}
