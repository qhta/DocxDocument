namespace DocumentModel.Interop;

public partial interface KeyBinding
{
  /// <summary>
  /// Removes the key binding from the KeyBindings collection and resets a built-in command to its default key assignment.
  /// </summary>
  public void Clear();
}
