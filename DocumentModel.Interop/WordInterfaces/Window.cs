namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a window.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window?view=word-pia"/>
public partial interface Window : InteropObject
{
  /// <summary>
  /// Returns the active pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.activepane?view=word-pia"/>
  public Pane ActivePane { get; }

  /// <summary>
  /// Returns the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// Returns the panes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.panes?view=word-pia"/>
  public Panes Panes { get; }

  /// <summary>
  /// Returns the selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.selection?view=word-pia"/>
  public Selection Selection { get; }

  /// <summary>
  /// Returns or sets the left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.left?view=word-pia"/>
  public int Left { get; set; }

  /// <summary>
  /// Returns or sets the top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.top?view=word-pia"/>
  public int Top { get; set; }

  /// <summary>
  /// Returns or sets the width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
  /// Returns or sets the height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
  /// Returns or sets whether split.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.split?view=word-pia"/>
  public bool Split { get; set; }

  /// <summary>
  /// Returns or sets the split vertical.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.splitvertical?view=word-pia"/>
  public int SplitVertical { get; set; }

  /// <summary>
  /// Returns or sets the caption.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// Returns or sets the window state.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.windowstate?view=word-pia"/>
  public WdWindowState WindowState { get; set; }

  /// <summary>
  /// Returns or sets whether display rulers.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayrulers?view=word-pia"/>
  public bool DisplayRulers { get; set; }

  /// <summary>
  /// Returns or sets whether display vertical ruler.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayverticalruler?view=word-pia"/>
  public bool DisplayVerticalRuler { get; set; }

  /// <summary>
  /// Returns the view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.view?view=word-pia"/>
  public View View { get; }

  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.type?view=word-pia"/>
  public WdWindowType Type { get; }

  /// <summary>
  /// Returns the next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.next?view=word-pia"/>
  public Window Next { get; }

  /// <summary>
  /// Returns the previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.previous?view=word-pia"/>
  public Window Previous { get; }

  /// <summary>
  /// Returns the window number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.windownumber?view=word-pia"/>
  public int WindowNumber { get; }

  /// <summary>
  /// Returns or sets whether display vertical scroll bar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayverticalscrollbar?view=word-pia"/>
  public bool DisplayVerticalScrollBar { get; set; }

  /// <summary>
  /// Returns or sets whether display horizontal scroll bar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayhorizontalscrollbar?view=word-pia"/>
  public bool DisplayHorizontalScrollBar { get; set; }

  /// <summary>
  /// Returns or sets the style area width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.styleareawidth?view=word-pia"/>
  public float StyleAreaWidth { get; set; }

  /// <summary>
  /// Returns or sets whether display screen tips.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayscreentips?view=word-pia"/>
  public bool DisplayScreenTips { get; set; }

  /// <summary>
  /// Returns or sets the horizontal percent scrolled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.horizontalpercentscrolled?view=word-pia"/>
  public int HorizontalPercentScrolled { get; set; }

  /// <summary>
  /// Returns or sets the vertical percent scrolled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.verticalpercentscrolled?view=word-pia"/>
  public int VerticalPercentScrolled { get; set; }

  /// <summary>
  /// Returns or sets whether document map.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.documentmap?view=word-pia"/>
  public bool DocumentMap { get; set; }

  /// <summary>
  /// Returns whether active.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.active?view=word-pia"/>
  public bool Active { get; }

  /// <summary>
  /// Returns or sets the document map percent width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.documentmappercentwidth?view=word-pia"/>
  public int DocumentMapPercentWidth { get; set; }

  /// <summary>
  /// Returns the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns or sets the i m e mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.imemode?view=word-pia"/>
  public WdIMEMode IMEMode { get; set; }

  /// <summary>
  /// Returns the usable width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.usablewidth?view=word-pia"/>
  public int UsableWidth { get; }

  /// <summary>
  /// Returns the usable height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.usableheight?view=word-pia"/>
  public int UsableHeight { get; }

  /// <summary>
  /// Returns or sets whether envelope visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.envelopevisible?view=word-pia"/>
  public bool EnvelopeVisible { get; set; }

  /// <summary>
  /// Returns or sets whether display right ruler.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayrightruler?view=word-pia"/>
  public bool DisplayRightRuler { get; set; }

  /// <summary>
  /// Returns or sets whether display left scroll bar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayleftscrollbar?view=word-pia"/>
  public bool DisplayLeftScrollBar { get; set; }

  /// <summary>
  /// Returns or sets whether visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.visible?view=word-pia"/>
  public bool Visible { get; set; }

  /// <summary>
  /// Returns or sets whether thumbnails.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.thumbnails?view=word-pia"/>
  public bool Thumbnails { get; set; }

  /// <summary>
  /// Returns or sets the show source documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.showsourcedocuments?view=word-pia"/>
  public WdShowSourceDocuments ShowSourceDocuments { get; set; }

  /// <summary>
  /// Returns the hwnd.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.hwnd?view=word-pia"/>
  public int Hwnd { get; }
}
