namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the tab stop alignment to apply.
/// </summary>
public enum WdTabAlignment
{
  /// <summary>
  /// Left aligned.
  /// </summary>
  wdAlignTabLeft = unchecked((int)0),
  /// <summary>
  /// Center aligned.
  /// </summary>
  wdAlignTabCenter = unchecked((int)1),
  /// <summary>
  /// Right aligned.
  /// </summary>
  wdAlignTabRight = unchecked((int)2),
  /// <summary>
  /// Decimal aligned.
  /// </summary>
  wdAlignTabDecimal = unchecked((int)3),
  /// <summary>
  /// Bar aligned.
  /// </summary>
  wdAlignTabBar = unchecked((int)4),
  /// <summary>
  /// List aligned.
  /// </summary>
  wdAlignTabList = unchecked((int)6)
}
