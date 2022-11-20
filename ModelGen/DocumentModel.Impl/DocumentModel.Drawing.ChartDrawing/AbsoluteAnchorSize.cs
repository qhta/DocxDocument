namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IExtent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IConnectionShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IGraphicFrame))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IGroupShape))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IFromAnchor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IShape))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ChartDrawing.IContentPart))]
public class AbsoluteAnchorSize: IAbsoluteAnchorSize
{
  /// <summary>
  /// FromAnchor.
  /// </summary>
  public IFromAnchor? FromAnchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.IExtent? Extent
  {
    get;
    set;
  }
  
}
