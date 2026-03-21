namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a custom key assignment in the current context.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding?view=word-pia"/>
public partial interface KeyBinding : InteropObject
{
  /// <summary>
  /// The command.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.command?view=word-pia"/>
  public string Command { get; }

  /// <summary>
  /// The key string.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keystring?view=word-pia"/>
  public string KeyString { get; }

  /// <summary>
  /// The protected.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.protected?view=word-pia"/>
  public bool Protected { get; }

  /// <summary>
  /// The key category.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keycategory?view=word-pia"/>
  public WdKeyCategory KeyCategory { get; }

  /// <summary>
  /// The key code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keycode?view=word-pia"/>
  public int KeyCode { get; }

  /// <summary>
  /// The key code2.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.keycode2?view=word-pia"/>
  public int KeyCode2 { get; }

  /// <summary>
  /// The command parameter.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.commandparameter?view=word-pia"/>
  public string CommandParameter { get; }

  /// <summary>
  /// The context.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybinding.context?view=word-pia"/>
  public object Context { get; }
}
