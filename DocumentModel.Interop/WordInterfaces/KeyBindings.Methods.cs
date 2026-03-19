namespace DocumentModel.Interop.Word;

public partial interface KeyBindings
{
  /// <summary>
  /// Adds a new key binding to the collection.
  /// </summary>
  /// <param name="KeyCategory">The category of the key binding.</param>
  /// <param name="Command">The command to execute when the key binding is pressed.</param>
  /// <param name="KeyCode">The primary key code for the key binding.</param>
  /// <param name="KeyCode2">An optional secondary key code for the key binding.</param>
  /// <param name="CommandParameter">An optional parameter for the command.</param>
  /// <returns>The created <see cref="KeyBinding"/> object.</returns>
  public KeyBinding Add(WdKeyCategory KeyCategory, string Command, int KeyCode, int KeyCode2, object CommandParameter);
}
