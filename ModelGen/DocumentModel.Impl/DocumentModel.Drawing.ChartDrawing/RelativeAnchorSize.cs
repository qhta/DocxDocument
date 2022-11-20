namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IConnectionShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IGraphicFrame))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IGroupShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IFromAnchor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IToAnchor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IShape))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ChartDrawing.IContentPart))]
public class RelativeAnchorSize: IRelativeAnchorSize
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public IFromAnchor? FromAnchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public IToAnchor? ToAnchor
  {
    get;
    set;
  }
  
}
