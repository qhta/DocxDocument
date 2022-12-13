namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public class RelativeAnchorSizeImpl: ModelElementImpl, RelativeAnchorSize
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RelativeAnchorSizeImpl(): base() {}
  
  public RelativeAnchorSizeImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.RelativeAnchorSize openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public DocumentModel.Drawings.Charts.FromAnchor? FromAnchor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public DocumentModel.Drawings.Charts.ToAnchor? ToAnchor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.Shape? Shape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.GroupShape? GroupShape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.GraphicFrame? GraphicFrame
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.ConnectionShape? ConnectionShape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.Picture? Picture
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
