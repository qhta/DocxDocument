namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a window.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window?view=word-pia"/>
public partial class Window : InteropObject
{
  /// <summary>
  /// Returns a Pane object that represents the active pane for the specified window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.activepane?view=word-pia"/>
  public Pane ActivePane { get; set; }

  /// <summary>
  /// Returns a Document object associated with the specified window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.document?view=word-pia"/>
  public Document Document { get; set; }

  /// <summary>
  /// Returns a Panes collection that represents all the window panes for the specified window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.panes?view=word-pia"/>
  public Panes Panes { get; set; }

  /// <summary>
  /// Returns the Selection object that represents a selected range or the insertion point.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.selection?view=word-pia"/>
  public Selection Selection { get; set; }

  /// <summary>
  /// Returns or sets an Integer that represents the horizontal position of the specified window, measured in
  /// points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.left?view=word-pia"/>
  public int Left { get; set; }

  /// <summary>
  /// Returns or sets the vertical position of the specified window, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.top?view=word-pia"/>
  public int Top { get; set; }

  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
  /// Returns or sets the height of the window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
  /// True if the window is split into multiple panes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.split?view=word-pia"/>
  public bool Split { get; set; }

  /// <summary>
  /// Returns or sets the vertical split percentage for the specified window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.splitvertical?view=word-pia"/>
  public int SplitVertical { get; set; }

  /// <summary>
  /// Returns or sets the caption text for the specified document or application window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.caption?view=word-pia"/>
  public string? Caption { get; set; }

  /// <summary>
  /// Returns or sets the state of the specified document window or task window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.windowstate?view=word-pia"/>
  public WindowState WindowState { get; set; }

  /// <summary>
  /// True if rulers are displayed for the specified window or pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayrulers?view=word-pia"/>
  public bool DisplayRulers { get; set; }

  /// <summary>
  /// True if a vertical ruler is displayed for the specified window or pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayverticalruler?view=word-pia"/>
  public bool DisplayVerticalRuler { get; set; }

  /// <summary>
  /// Returns a View object that represents the view for the specified window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.view?view=word-pia"/>
  public View View { get; set; }

  /// <summary>
  /// Returns the window type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.type?view=word-pia"/>
  public WindowType Type { get; set; }

  /// <summary>
  /// Returns the next object in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.next?view=word-pia"/>
  public Window Next { get; set; }

  /// <summary>
  /// Returns the previous object in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.previous?view=word-pia"/>
  public Window Previous { get; set; }

  /// <summary>
  /// Returns the window number of the document displayed in the specified window. For example, if the caption of
  /// the window is "Sales.doc:2", this property returns the number 2.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.windownumber?view=word-pia"/>
  public int WindowNumber { get; set; }

  /// <summary>
  /// True if a vertical scroll bar is displayed for the specified window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayverticalscrollbar?view=word-pia"/>
  public bool DisplayVerticalScrollBar { get; set; }

  /// <summary>
  /// True if a horizontal scroll bar is displayed for the specified window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayhorizontalscrollbar?view=word-pia"/>
  public bool DisplayHorizontalScrollBar { get; set; }

  /// <summary>
  /// Returns or sets the width of the style area in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.styleareawidth?view=word-pia"/>
  public float StyleAreaWidth { get; set; }

  /// <summary>
  /// True if comments, footnotes, endnotes, and hyperlinks are displayed as tips. Text marked as having comments is
  /// highlighted.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayscreentips?view=word-pia"/>
  public bool DisplayScreenTips { get; set; }

  /// <summary>
  /// Returns or sets the horizontal scroll position as a percentage of the document width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.horizontalpercentscrolled?view=word-pia"/>
  public int HorizontalPercentScrolled { get; set; }

  /// <summary>
  /// Returns or sets the vertical scroll position as a percentage of the document length.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.verticalpercentscrolled?view=word-pia"/>
  public int VerticalPercentScrolled { get; set; }

  /// <summary>
  /// True if the document map is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.documentmap?view=word-pia"/>
  public bool DocumentMap { get; set; }

  /// <summary>
  /// True if the specified window is active.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.active?view=word-pia"/>
  public bool Active { get; set; }

  /// <summary>
  /// Returns or sets the width of the document map as a percentage of the width of the specified window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.documentmappercentwidth?view=word-pia"/>
  public int DocumentMapPercentWidth { get; set; }

  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Returns or sets the default start-up mode for the Japanese Input Method Editor (IME).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.imemode?view=word-pia"/>
  public IMEMode IMEMode { get; set; }

  /// <summary>
  /// Returns the width (in points) of the active working area in the specified document window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.usablewidth?view=word-pia"/>
  public int UsableWidth { get; set; }

  /// <summary>
  /// Returns the height (in points) of the active working area in the specified document window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.usableheight?view=word-pia"/>
  public int UsableHeight { get; set; }

  /// <summary>
  /// True if the e-mail message header is visible in the document window. The default value is False.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.envelopevisible?view=word-pia"/>
  public bool EnvelopeVisible { get; set; }

  /// <summary>
  /// True if the vertical ruler appears on the right side of the document window in print layout view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayrightruler?view=word-pia"/>
  public bool DisplayRightRuler { get; set; }

  /// <summary>
  /// True if the vertical scroll bar appears on the left side of the document window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayleftscrollbar?view=word-pia"/>
  public bool DisplayLeftScrollBar { get; set; }

  /// <summary>
  /// True if the specified object is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.visible?view=word-pia"/>
  public bool Visible { get; set; }

  /// <summary>
  /// Sets or returns a Boolean that represents whether thumbnail images of the pages in a document are displayed
  /// along the left side of the Microsoft Word document window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.thumbnails?view=word-pia"/>
  public bool Thumbnails { get; set; }

  /// <summary>
  /// Returns or sets a ShowSourceDocuments constant that represents how Microsoft Office Word displays source
  /// documents after a compare and merge process. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.showsourcedocuments?view=word-pia"/>
  public ShowSourceDocuments ShowSourceDocuments { get; set; }

  /// <summary>
  /// Returns an Integer (int in C#) that indicates the window handle of the specified window. Read- only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.hwnd?view=word-pia"/>
  public int Hwnd { get; set; }


  #region methods

/// <summary>
  /// Activates the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.activate?view=word-pia"/>
  public void Activate() { throw new NotImplementedException(); }

  #endregion methods
}
