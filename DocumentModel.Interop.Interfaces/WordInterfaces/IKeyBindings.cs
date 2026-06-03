namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of KeyBinding objects that represent the custom key assignments in the current context. Custom key assignments are made in the Customize Keyboard dialog box.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybindings?view=word-pia"/>
public interface IKeyBindings : IInteropObject, IInteropCollection<IKeyBinding>
{
  /// <summary>
  /// Returns an object that represents the storage location of the specified key binding.
  /// This property can return a Document, Template, or Application object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybindings.context?view=word-pia"/>
  public object Context { get; }


  #region methods

/// <summary>
  /// Adds a new key binding to the collection.
  /// </summary>
  /// <param name="keyCategory">The category of the key binding.</param>
  /// <param name="command">The command to execute when the key binding is pressed.</param>
  /// <param name="keyCode">The primary key code for the key binding.</param>
  /// <param name="keyCode2">An optional secondary key code for the key binding.</param>
  /// <param name="commandParameter">An optional parameter for the command.</param>
  /// <returns>The created <see cref="IKeyBinding"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybindings.add?view=word-pia"/>
  public IKeyBinding Add(KeyCategory keyCategory, string command, int keyCode, int keyCode2, object commandParameter);

  #endregion methods
}
