namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the default justification for equations.
/// </summary>
public enum WdOMathJc
{
  /// <summary>
  /// Center as a group.
  /// </summary>
  wdOMathJcCenterGroup = unchecked((int)1),
  /// <summary>
  /// Center.
  /// </summary>
  wdOMathJcCenter = unchecked((int)2),
  /// <summary>
  /// Left.
  /// </summary>
  wdOMathJcLeft = unchecked((int)3),
  /// <summary>
  /// Right.
  /// </summary>
  wdOMathJcRight = unchecked((int)4),
  /// <summary>
  /// Inline.
  /// </summary>
  wdOMathJcInline = unchecked((int)7)
}
