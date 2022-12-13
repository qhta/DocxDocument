namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public class AbsoluteAnchorSizeImpl: ModelElementImpl, AbsoluteAnchorSize
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AbsoluteAnchorSizeImpl(): base() {}
  
  public AbsoluteAnchorSizeImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.AbsoluteAnchorSize openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// FromAnchor.
  /// </summary>
  public DocumentModel.Drawings.Charts.FromAnchor? FromAnchor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public DocumentModel.Drawings.Charts.Extent? Extent
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
