namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a custom key assignment in the current context.
/// </summary>
public partial interface KeyBinding : InteropObject
{
  /// <summary>
  /// The command.
  /// </summary>
  public string Command { get; }

  /// <summary>
  /// The key string.
  /// </summary>
  public string KeyString { get; }

  /// <summary>
  /// The protected.
  /// </summary>
  public bool Protected { get; }

  /// <summary>
  /// The key category.
  /// </summary>
  public WdKeyCategory KeyCategory { get; }

  /// <summary>
  /// The key code.
  /// </summary>
  public int KeyCode { get; }

  /// <summary>
  /// The key code2.
  /// </summary>
  public int KeyCode2 { get; }

  /// <summary>
  /// The command parameter.
  /// </summary>
  public string CommandParameter { get; }

  /// <summary>
  /// The context.
  /// </summary>
  public object Context { get; }
}
