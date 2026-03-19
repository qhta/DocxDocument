namespace DocumentModel.Interop.Word;

public partial interface StyleSheet
{
  /// <summary>
  /// Moves the style sheet to a new precedence level.
  /// </summary>
  /// <param name="Precedence">The new precedence for the style sheet.</param>
  public void Move(WdStyleSheetPrecedence Precedence);
}
