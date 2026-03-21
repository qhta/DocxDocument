namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a window pane. The Pane object is a member of the Panes collection. The Panes#SameCHM collection includes all the window panes for a single window.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane?view=word-pia"/>
public partial interface Pane : InteropObject
{
  /// <summary>
  /// The document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// The selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.selection?view=word-pia"/>
  public Selection Selection { get; }

  /// <summary>
  /// The display rulers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.displayrulers?view=word-pia"/>
  public bool DisplayRulers { get; set; }

  /// <summary>
  /// The display vertical ruler.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.displayverticalruler?view=word-pia"/>
  public bool DisplayVerticalRuler { get; set; }

  /// <summary>
  /// The zooms.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.zooms?view=word-pia"/>
  public Zooms Zooms { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.view?view=word-pia"/>
  public View View { get; }

  /// <summary>
  /// The next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.next?view=word-pia"/>
  public Pane Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.previous?view=word-pia"/>
  public Pane Previous { get; }

  /// <summary>
  /// The horizontal percent scrolled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.horizontalpercentscrolled?view=word-pia"/>
  public int HorizontalPercentScrolled { get; set; }

  /// <summary>
  /// The vertical percent scrolled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.verticalpercentscrolled?view=word-pia"/>
  public int VerticalPercentScrolled { get; set; }

  /// <summary>
  /// The minimum font size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.minimumfontsize?view=word-pia"/>
  public int MinimumFontSize { get; set; }

  /// <summary>
  /// The browse to window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.browsetowindow?view=word-pia"/>
  public bool BrowseToWindow { get; set; }

  /// <summary>
  /// The browse width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.browsewidth?view=word-pia"/>
  public int BrowseWidth { get; }

  /// <summary>
  /// The frameset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.frameset?view=word-pia"/>
  public Frameset Frameset { get; }

  /// <summary>
  /// The pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.pages?view=word-pia"/>
  public Pages Pages { get; }
}
