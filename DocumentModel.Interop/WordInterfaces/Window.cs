namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a window.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window?view=word-pia"/>
public partial interface Window : InteropObject
{
  /// <summary>
  /// The active pane.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.activepane?view=word-pia"/>
  public Pane ActivePane { get; }

  /// <summary>
  /// The document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// The panes.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.panes?view=word-pia"/>
  public Panes Panes { get; }

  /// <summary>
  /// The selection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.selection?view=word-pia"/>
  public Selection Selection { get; }

  /// <summary>
  /// The left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.left?view=word-pia"/>
  public int Left { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.top?view=word-pia"/>
  public int Top { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
  /// The split.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.split?view=word-pia"/>
  public bool Split { get; set; }

  /// <summary>
  /// The split vertical.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.splitvertical?view=word-pia"/>
  public int SplitVertical { get; set; }

  /// <summary>
  /// The caption.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// The window state.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.windowstate?view=word-pia"/>
  public WdWindowState WindowState { get; set; }

  /// <summary>
  /// The display rulers.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayrulers?view=word-pia"/>
  public bool DisplayRulers { get; set; }

  /// <summary>
  /// The display vertical ruler.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayverticalruler?view=word-pia"/>
  public bool DisplayVerticalRuler { get; set; }

  /// <summary>
  /// The view.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.view?view=word-pia"/>
  public View View { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.type?view=word-pia"/>
  public WdWindowType Type { get; }

  /// <summary>
  /// The next.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.next?view=word-pia"/>
  public Window Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.previous?view=word-pia"/>
  public Window Previous { get; }

  /// <summary>
  /// The window number.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.windownumber?view=word-pia"/>
  public int WindowNumber { get; }

  /// <summary>
  /// The display vertical scroll bar.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayverticalscrollbar?view=word-pia"/>
  public bool DisplayVerticalScrollBar { get; set; }

  /// <summary>
  /// The display horizontal scroll bar.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayhorizontalscrollbar?view=word-pia"/>
  public bool DisplayHorizontalScrollBar { get; set; }

  /// <summary>
  /// The style area width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.styleareawidth?view=word-pia"/>
  public float StyleAreaWidth { get; set; }

  /// <summary>
  /// The display screen tips.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayscreentips?view=word-pia"/>
  public bool DisplayScreenTips { get; set; }

  /// <summary>
  /// The horizontal percent scrolled.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.horizontalpercentscrolled?view=word-pia"/>
  public int HorizontalPercentScrolled { get; set; }

  /// <summary>
  /// The vertical percent scrolled.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.verticalpercentscrolled?view=word-pia"/>
  public int VerticalPercentScrolled { get; set; }

  /// <summary>
  /// The document map.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.documentmap?view=word-pia"/>
  public bool DocumentMap { get; set; }

  /// <summary>
  /// The active.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.active?view=word-pia"/>
  public bool Active { get; }

  /// <summary>
  /// The document map percent width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.documentmappercentwidth?view=word-pia"/>
  public int DocumentMapPercentWidth { get; set; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The imemode.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.imemode?view=word-pia"/>
  public WdIMEMode IMEMode { get; set; }

  /// <summary>
  /// The usable width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.usablewidth?view=word-pia"/>
  public int UsableWidth { get; }

  /// <summary>
  /// The usable height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.usableheight?view=word-pia"/>
  public int UsableHeight { get; }

  /// <summary>
  /// The envelope visible.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.envelopevisible?view=word-pia"/>
  public bool EnvelopeVisible { get; set; }

  /// <summary>
  /// The display right ruler.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayrightruler?view=word-pia"/>
  public bool DisplayRightRuler { get; set; }

  /// <summary>
  /// The display left scroll bar.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.displayleftscrollbar?view=word-pia"/>
  public bool DisplayLeftScrollBar { get; set; }

  /// <summary>
  /// The visible.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.visible?view=word-pia"/>
  public bool Visible { get; set; }

  /// <summary>
  /// The thumbnails.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.thumbnails?view=word-pia"/>
  public bool Thumbnails { get; set; }

  /// <summary>
  /// The show source documents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.showsourcedocuments?view=word-pia"/>
  public WdShowSourceDocuments ShowSourceDocuments { get; set; }

  /// <summary>
  /// The hwnd.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.window.hwnd?view=word-pia"/>
  public int Hwnd { get; }
}
