namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a custom key assignment in the current context.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding?view=word-pia"/>
public partial interface KeyBinding : InteropObject
{
  /// <summary>
  /// The command.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.command?view=word-pia"/>
  public string Command { get; }

  /// <summary>
  /// The key string.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keystring?view=word-pia"/>
  public string KeyString { get; }

  /// <summary>
  /// The protected.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.protected?view=word-pia"/>
  public bool Protected { get; }

  /// <summary>
  /// The key category.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keycategory?view=word-pia"/>
  public WdKeyCategory KeyCategory { get; }

  /// <summary>
  /// The key code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keycode?view=word-pia"/>
  public int KeyCode { get; }

  /// <summary>
  /// The key code2.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keycode2?view=word-pia"/>
  public int KeyCode2 { get; }

  /// <summary>
  /// The command parameter.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.commandparameter?view=word-pia"/>
  public string CommandParameter { get; }

  /// <summary>
  /// The context.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.context?view=word-pia"/>
  public object Context { get; }
}
