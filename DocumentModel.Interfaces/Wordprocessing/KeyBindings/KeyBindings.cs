namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of KeyBinding objects that represent the custom key assignments in the current context. Custom key assignments are made in the Customize Keyboard dialog box.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybindings?view=word-pia"/>
public partial interface IKeyBindings : IModelCollection<IKeyBinding>
{
  /// <summary>
  /// Returns an object that represents the storage location of the specified key binding.
  /// This property can return a Document, Template, or Application object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybindings.context?view=word-pia"/>
  public object Context { get; }
}
