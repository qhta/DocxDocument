namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the tab stop alignment to apply.
/// </summary>
public enum WdTabAlignment
{
  /// <summary>
  /// Left aligned.
  /// </summary>
  Left = unchecked((int)0),
  /// <summary>
  /// Center aligned.
  /// </summary>
  Center = unchecked((int)1),
  /// <summary>
  /// Right aligned.
  /// </summary>
  Right = unchecked((int)2),
  /// <summary>
  /// Decimal aligned.
  /// </summary>
  Decimal = unchecked((int)3),
  /// <summary>
  /// Bar aligned.
  /// </summary>
  Bar = unchecked((int)4),
  /// <summary>
  /// List aligned.
  /// </summary>
  List = unchecked((int)6)
}
