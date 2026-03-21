namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of KeyBinding objects that represent the custom key assignments in the current context. Custom key assignments are made in the Customize Keyboard dialog box.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybindings?view=word-pia"/>
public partial interface KeyBindings : InteropObject, InteropCollection<KeyBinding>
{
  /// <summary>
  /// The context.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.keybindings.context?view=word-pia"/>
  public object Context { get; }
}
