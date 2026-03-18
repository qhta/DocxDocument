namespace DocumentModel.Interop;

/// <summary>
/// A collection of KeyBinding objects assigned to a command, style, macro, or other item in the current context.
/// </summary>
public partial interface KeysBoundTo : InteropObject, InteropCollection<KeyBinding>
{
  /// <summary>
  /// The key category.
  /// </summary>
  public WdKeyCategory KeyCategory { get; }

  /// <summary>
  /// The command.
  /// </summary>
  public string Command { get; }

  /// <summary>
  /// The command parameter.
  /// </summary>
  public string CommandParameter { get; }

  /// <summary>
  /// The context.
  /// </summary>
  public object Context { get; }
}
