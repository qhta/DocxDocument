namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of KeyBinding objects assigned to a command, style, macro, or other item in the current context.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto?view=word-pia"/>
public interface IKeysBoundTo : IInteropObject, IInteropCollection<IKeyBinding>
{
  /// <summary>
  /// Returns the type of item assigned to the specified key binding.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto.keycategory?view=word-pia"/>
  public KeyCategory KeyCategory { get; }

  /// <summary>
  /// Returns the command assigned to the specified key combination.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto.command?view=word-pia"/>
  public string Command { get; }

  /// <summary>
  /// Returns the command parameter assigned to the specified shortcut key.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto.commandparameter?view=word-pia"/>
  public string CommandParameter { get; }

  /// <summary>
  /// Returns an object that represents the storage location of the specified key binding.
  /// This property can return a Document, Template, or Application object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto.context?view=word-pia"/>
  public object Context { get; }


  #region methods

/// <summary>
  /// Returns the key binding for the specified key combination.
  /// </summary>
  /// <param name="keyCode">The primary key code.</param>
  /// <param name="keyCode2">The secondary key code.</param>
  /// <returns>The <see cref="IKeyBinding"/> object for the specified keys.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keysboundto.key?view=word-pia"/>
  public IKeyBinding Key(int keyCode, int keyCode2);

  #endregion methods
}
