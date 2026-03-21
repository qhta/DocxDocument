namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a window pane. The Pane object is a member of the Panes collection. The Panes#SameCHM collection includes all the window panes for a single window.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane?view=word-pia"/>
public partial interface Pane : InteropObject
{
  /// <summary>
  /// The document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// The selection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.selection?view=word-pia"/>
  public Selection Selection { get; }

  /// <summary>
  /// The display rulers.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.displayrulers?view=word-pia"/>
  public bool DisplayRulers { get; set; }

  /// <summary>
  /// The display vertical ruler.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.displayverticalruler?view=word-pia"/>
  public bool DisplayVerticalRuler { get; set; }

  /// <summary>
  /// The zooms.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.zooms?view=word-pia"/>
  public Zooms Zooms { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The view.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.view?view=word-pia"/>
  public View View { get; }

  /// <summary>
  /// The next.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.next?view=word-pia"/>
  public Pane Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.previous?view=word-pia"/>
  public Pane Previous { get; }

  /// <summary>
  /// The horizontal percent scrolled.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.horizontalpercentscrolled?view=word-pia"/>
  public int HorizontalPercentScrolled { get; set; }

  /// <summary>
  /// The vertical percent scrolled.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.verticalpercentscrolled?view=word-pia"/>
  public int VerticalPercentScrolled { get; set; }

  /// <summary>
  /// The minimum font size.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.minimumfontsize?view=word-pia"/>
  public int MinimumFontSize { get; set; }

  /// <summary>
  /// The browse to window.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.browsetowindow?view=word-pia"/>
  public bool BrowseToWindow { get; set; }

  /// <summary>
  /// The browse width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.browsewidth?view=word-pia"/>
  public int BrowseWidth { get; }

  /// <summary>
  /// The frameset.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.frameset?view=word-pia"/>
  public Frameset Frameset { get; }

  /// <summary>
  /// The pages.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.pages?view=word-pia"/>
  public Pages Pages { get; }
}
