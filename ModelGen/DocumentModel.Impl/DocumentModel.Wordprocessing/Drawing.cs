namespace DocumentModel.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IAnchor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Wordprocessing.IInline))]
public class Drawing: IDrawing
{
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  public DocumentModel.Drawing.Wordprocessing.IAnchor? Anchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  public IInline? Inline
  {
    get;
    set;
  }
  
}
