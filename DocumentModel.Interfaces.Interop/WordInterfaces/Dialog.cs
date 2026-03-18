namespace DocumentModel.Interop;

/// <summary>
/// Represents a built-in dialog box.
/// </summary>
public partial interface Dialog : InteropObject
{
  /// <summary>
  /// The default tab.
  /// </summary>
  public WdWordDialogTab DefaultTab { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdWordDialog Type { get; }

  /// <summary>
  /// The command name.
  /// </summary>
  public string CommandName { get; }

  /// <summary>
  /// The command bar id.
  /// </summary>
  public int CommandBarId { get; }
}
