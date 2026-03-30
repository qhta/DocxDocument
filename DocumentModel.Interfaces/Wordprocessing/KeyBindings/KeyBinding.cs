namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a custom key assignment in the current context.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding?view=word-pia"/>
public partial interface KeyBinding : IModelObject
{
  /// <summary>
  /// Returns the command assigned to the key binding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.command?view=word-pia"/>
  public string Command { get; }

  /// <summary>
  /// Returns a string that represents the key combination.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keystring?view=word-pia"/>
  public string KeyString { get; }

  /// <summary>
  /// Returns whether the key binding is protected from user modification.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.protected?view=word-pia"/>
  public bool Protected { get; }

  /// <summary>
  /// Returns the category of the key binding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keycategory?view=word-pia"/>
  public KeyCategory KeyCategory { get; }

  /// <summary>
  /// Returns the primary key code of the key binding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keycode?view=word-pia"/>
  public int KeyCode { get; }

  /// <summary>
  /// Returns the secondary key code of the key binding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keycode2?view=word-pia"/>
  public int KeyCode2 { get; }

  /// <summary>
  /// Returns the parameter string used with the bound command.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.commandparameter?view=word-pia"/>
  public string CommandParameter { get; }

  /// <summary>
  /// Returns the context in which the key binding is active.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.context?view=word-pia"/>
  public object Context { get; }
}
