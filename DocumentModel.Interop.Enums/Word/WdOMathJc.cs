namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the default justification for equations.
/// </summary>
public enum WdOMathJc
{
  /// <summary>
  /// Center as a group.
  /// </summary>
  CenterGroup = unchecked((int)1),
  /// <summary>
  /// Center.
  /// </summary>
  Center = unchecked((int)2),
  /// <summary>
  /// Left.
  /// </summary>
  Left = unchecked((int)3),
  /// <summary>
  /// Right.
  /// </summary>
  Right = unchecked((int)4),
  /// <summary>
  /// Inline.
  /// </summary>
  Inline = unchecked((int)7)
}
