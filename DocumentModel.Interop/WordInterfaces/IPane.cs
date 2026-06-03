namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a window pane. The Pane object is a member of the Panes collection. The Panes#SameCHM collection
/// includes all the window panes for a single window.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane?view=word-pia"/>
public interface IPane : IInteropObject
{
  /// <summary>
  /// Returns a Document object associated with the specified pane. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.document?view=word-pia"/>
  public IDocument document { get; }

  /// <summary>
  /// Returns the Selection object that represents a selection or the insertion point within a document pane.
  /// Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.selection?view=word-pia"/>
  public ISelection ISelection { get; }

  /// <summary>
  /// True if rulers are displayed for the specified pane. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.displayrulers?view=word-pia"/>
  public bool DisplayRulers { get; set; }

  /// <summary>
  /// True if a vertical ruler is displayed for the specified pane. Read/write Boolean.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.displayverticalruler?view=word-pia"/>
  public bool DisplayVerticalRuler { get; set; }

  /// <summary>
  /// Returns a Zooms#SameCHM collection that represents the magnification options for each view (such as normal
  /// view, outline view or print layout view).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.zooms?view=word-pia"/>
  public IZooms IZooms { get; }

  /// <summary>
  /// Returns a Long that represents the position of an item in a collection. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns a View object that represents the view for the specified pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.view?view=word-pia"/>
  public IView IView { get; }

  /// <summary>
  /// Returns a Pane object that represents the next document pane in the collection. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.next?view=word-pia"/>
  public IPane Next { get; }

  /// <summary>
  /// Returns a Pane object that represents the previous document pane in the collection. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.previous?view=word-pia"/>
  public IPane Previous { get; }

  /// <summary>
  /// Returns or sets the horizontal scroll position as a percentage of the document width. Read/write Long.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.horizontalpercentscrolled?view=word-pia"/>
  public int HorizontalPercentScrolled { get; set; }

  /// <summary>
  /// Returns or sets the vertical scroll position as a percentage of the document length. Read/write Long.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.verticalpercentscrolled?view=word-pia"/>
  public int VerticalPercentScrolled { get; set; }

  /// <summary>
  /// Returns or sets the minimum font size (in points) displayed for the specified pane. Read/write Long.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.minimumfontsize?view=word-pia"/>
  public int MinimumFontSize { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.browsetowindow?view=word-pia"/>
  public bool BrowseToWindow { get; set; }

  /// <summary>
  /// Returns the width (in points) of the area in which text wraps in the specified pane. Read-only Long.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.browsewidth?view=word-pia"/>
  public int BrowseWidth { get; }

  /// <summary>
  /// Returns a Frameset object that represents an entire frames page or a single frame on a frames page. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.frameset?view=word-pia"/>
  public IFrameset IFrameset { get; }

  /// <summary>
  /// Returns a Pages collection that represents the pages in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.pages?view=word-pia"/>
  public IPages IPages { get; }


  #region methods

/// <summary>
  /// Activates the specified pane.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pane.activate?view=word-pia"/>
  public void Activate();

  #endregion methods
}
