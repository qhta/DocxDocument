namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a window pane. The Pane object is a member of the Panes collection. The Panes#SameCHM collection includes all the window panes for a single window.
/// </summary>
public partial interface Pane : InteropObject
{
  /// <summary>
  /// The document.
  /// </summary>
  public Document Document { get; }

  /// <summary>
  /// The selection.
  /// </summary>
  public Selection Selection { get; }

  /// <summary>
  /// The display rulers.
  /// </summary>
  public bool DisplayRulers { get; set; }

  /// <summary>
  /// The display vertical ruler.
  /// </summary>
  public bool DisplayVerticalRuler { get; set; }

  /// <summary>
  /// The zooms.
  /// </summary>
  public Zooms Zooms { get; }

  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

  /// <summary>
  /// The view.
  /// </summary>
  public View View { get; }

  /// <summary>
  /// The next.
  /// </summary>
  public Pane Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  public Pane Previous { get; }

  /// <summary>
  /// The horizontal percent scrolled.
  /// </summary>
  public int HorizontalPercentScrolled { get; set; }

  /// <summary>
  /// The vertical percent scrolled.
  /// </summary>
  public int VerticalPercentScrolled { get; set; }

  /// <summary>
  /// The minimum font size.
  /// </summary>
  public int MinimumFontSize { get; set; }

  /// <summary>
  /// The browse to window.
  /// </summary>
  public bool BrowseToWindow { get; set; }

  /// <summary>
  /// The browse width.
  /// </summary>
  public int BrowseWidth { get; }

  /// <summary>
  /// The frameset.
  /// </summary>
  public Frameset Frameset { get; }

  /// <summary>
  /// The pages.
  /// </summary>
  public Pages Pages { get; }
}
