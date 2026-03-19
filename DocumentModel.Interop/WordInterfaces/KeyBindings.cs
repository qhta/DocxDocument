namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of KeyBinding objects that represent the custom key assignments in the current context. Custom key assignments are made in the Customize Keyboard dialog box.
/// </summary>
public partial interface KeyBindings : InteropObject, InteropCollection<KeyBinding>
{
  /// <summary>
  /// The context.
  /// </summary>
  public object Context { get; }
}
