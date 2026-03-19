namespace DocumentModel.Interop.Word;

public partial interface KeysBoundTo
{
  /// <summary>
  /// Returns the key binding for the specified key combination.
  /// </summary>
  /// <param name="KeyCode">The primary key code.</param>
  /// <param name="KeyCode2">The secondary key code.</param>
  /// <returns>The <see cref="KeyBinding"/> object for the specified keys.</returns>
  public KeyBinding Key(int KeyCode, int KeyCode2);
}
