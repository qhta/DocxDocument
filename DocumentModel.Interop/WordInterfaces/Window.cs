namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a window.
/// </summary>
public partial interface Window : InteropObject
{
  /// <summary>
  /// The active pane.
  /// </summary>
  public Pane ActivePane { get; }

  /// <summary>
  /// The document.
  /// </summary>
  public Document Document { get; }

  /// <summary>
  /// The panes.
  /// </summary>
  public Panes Panes { get; }

  /// <summary>
  /// The selection.
  /// </summary>
  public Selection Selection { get; }

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
  /// The split.
  /// </summary>
  public bool Split { get; set; }

  /// <summary>
  /// The split vertical.
  /// </summary>
  public int SplitVertical { get; set; }

  /// <summary>
  /// The caption.
  /// </summary>
  public string Caption { get; set; }

  /// <summary>
  /// The window state.
  /// </summary>
  public WdWindowState WindowState { get; set; }

  /// <summary>
  /// The display rulers.
  /// </summary>
  public bool DisplayRulers { get; set; }

  /// <summary>
  /// The display vertical ruler.
  /// </summary>
  public bool DisplayVerticalRuler { get; set; }

  /// <summary>
  /// The view.
  /// </summary>
  public View View { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdWindowType Type { get; }

  /// <summary>
  /// The next.
  /// </summary>
  public Window Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  public Window Previous { get; }

  /// <summary>
  /// The window number.
  /// </summary>
  public int WindowNumber { get; }

  /// <summary>
  /// The display vertical scroll bar.
  /// </summary>
  public bool DisplayVerticalScrollBar { get; set; }

  /// <summary>
  /// The display horizontal scroll bar.
  /// </summary>
  public bool DisplayHorizontalScrollBar { get; set; }

  /// <summary>
  /// The style area width.
  /// </summary>
  public float StyleAreaWidth { get; set; }

  /// <summary>
  /// The display screen tips.
  /// </summary>
  public bool DisplayScreenTips { get; set; }

  /// <summary>
  /// The horizontal percent scrolled.
  /// </summary>
  public int HorizontalPercentScrolled { get; set; }

  /// <summary>
  /// The vertical percent scrolled.
  /// </summary>
  public int VerticalPercentScrolled { get; set; }

  /// <summary>
  /// The document map.
  /// </summary>
  public bool DocumentMap { get; set; }

  /// <summary>
  /// The active.
  /// </summary>
  public bool Active { get; }

  /// <summary>
  /// The document map percent width.
  /// </summary>
  public int DocumentMapPercentWidth { get; set; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The imemode.
  /// </summary>
  public WdIMEMode IMEMode { get; set; }

  /// <summary>
  /// The usable width.
  /// </summary>
  public int UsableWidth { get; }

  /// <summary>
  /// The usable height.
  /// </summary>
  public int UsableHeight { get; }

  /// <summary>
  /// The envelope visible.
  /// </summary>
  public bool EnvelopeVisible { get; set; }

  /// <summary>
  /// The display right ruler.
  /// </summary>
  public bool DisplayRightRuler { get; set; }

  /// <summary>
  /// The display left scroll bar.
  /// </summary>
  public bool DisplayLeftScrollBar { get; set; }

  /// <summary>
  /// The visible.
  /// </summary>
  public bool Visible { get; set; }

  /// <summary>
  /// The thumbnails.
  /// </summary>
  public bool Thumbnails { get; set; }

  /// <summary>
  /// The show source documents.
  /// </summary>
  public WdShowSourceDocuments ShowSourceDocuments { get; set; }

  /// <summary>
  /// The hwnd.
  /// </summary>
  public int Hwnd { get; }
}
