namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single task running on the system.
/// </summary>
public partial interface Task : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The left.
  /// </summary>
  public int Left { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  public int Top { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  public int Width { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  public int Height { get; set; }

  /// <summary>
  /// The window state.
  /// </summary>
  public WdWindowState WindowState { get; set; }

  /// <summary>
  /// The visible.
  /// </summary>
  public bool Visible { get; set; }
}
