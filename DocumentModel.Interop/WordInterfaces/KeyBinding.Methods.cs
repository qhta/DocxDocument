namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding?view=word-pia"/>
public partial interface IKeyBinding
{
  /// <summary>
  /// Removes the key binding from the KeyBindings collection and resets a built-in command to its default key
  /// assignment.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.clear?view=word-pia"/>
  public void Clear();
}
