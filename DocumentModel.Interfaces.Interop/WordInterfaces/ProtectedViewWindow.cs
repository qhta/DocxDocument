namespace DocumentModel.Interop;

/// <summary>
/// Represents a protected view window.
/// </summary>
public partial interface ProtectedViewWindow : InteropObject
{
  /// <summary>
  /// The caption.
  /// </summary>
  public string Caption { get; set; }

  /// <summary>
  /// The document.
  /// </summary>
  public Document Document { get; }

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
  /// The active.
  /// </summary>
  public bool Active { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The visible.
  /// </summary>
  public bool Visible { get; set; }

  /// <summary>
  /// The source name.
  /// </summary>
  public string SourceName { get; }

  /// <summary>
  /// The source path.
  /// </summary>
  public string SourcePath { get; }
}
