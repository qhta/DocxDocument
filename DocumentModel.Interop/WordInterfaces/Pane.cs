namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a window pane. The Pane object is a member of the Panes collection. The Panes#SameCHM collection includes all the window panes for a single window.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane?view=word-pia"/>
public partial interface Pane : InteropObject
{
  /// <summary>
  /// Returns the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// Returns the selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.selection?view=word-pia"/>
  public Selection Selection { get; }

  /// <summary>
  /// Returns or sets whether display rulers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.displayrulers?view=word-pia"/>
  public bool DisplayRulers { get; set; }

  /// <summary>
  /// Returns or sets whether display vertical ruler.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.displayverticalruler?view=word-pia"/>
  public bool DisplayVerticalRuler { get; set; }

  /// <summary>
  /// Returns the zooms.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.zooms?view=word-pia"/>
  public Zooms Zooms { get; }

  /// <summary>
  /// Returns the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns the view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.view?view=word-pia"/>
  public View View { get; }

  /// <summary>
  /// Returns the next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.next?view=word-pia"/>
  public Pane Next { get; }

  /// <summary>
  /// Returns the previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.previous?view=word-pia"/>
  public Pane Previous { get; }

  /// <summary>
  /// Returns or sets the horizontal percent scrolled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.horizontalpercentscrolled?view=word-pia"/>
  public int HorizontalPercentScrolled { get; set; }

  /// <summary>
  /// Returns or sets the vertical percent scrolled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.verticalpercentscrolled?view=word-pia"/>
  public int VerticalPercentScrolled { get; set; }

  /// <summary>
  /// Returns or sets the minimum font size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.minimumfontsize?view=word-pia"/>
  public int MinimumFontSize { get; set; }

  /// <summary>
  /// Returns or sets whether browse to window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.browsetowindow?view=word-pia"/>
  public bool BrowseToWindow { get; set; }

  /// <summary>
  /// Returns the browse width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.browsewidth?view=word-pia"/>
  public int BrowseWidth { get; }

  /// <summary>
  /// Returns the frameset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.frameset?view=word-pia"/>
  public Frameset Frameset { get; }

  /// <summary>
  /// Returns the pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.pages?view=word-pia"/>
  public Pages Pages { get; }
}
