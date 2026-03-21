namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of KeyBinding objects assigned to a command, style, macro, or other item in the current context.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto?view=word-pia"/>
public partial interface KeysBoundTo : InteropObject, InteropCollection<KeyBinding>
{
  /// <summary>
  /// The key category.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto.keycategory?view=word-pia"/>
  public WdKeyCategory KeyCategory { get; }

  /// <summary>
  /// The command.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto.command?view=word-pia"/>
  public string Command { get; }

  /// <summary>
  /// The command parameter.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto.commandparameter?view=word-pia"/>
  public string CommandParameter { get; }

  /// <summary>
  /// The context.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto.context?view=word-pia"/>
  public object Context { get; }
}
