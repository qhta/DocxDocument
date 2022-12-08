namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// FromAnchor.
  /// </summary>
  public FromAnchor? FromAnchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public Extent? Extent
  {
    get;
    set;
  }
  
  public Shape1? Shape
  {
    get;
    set;
  }
  
  public GroupShape1? GroupShape
  {
    get;
    set;
  }
  
  public GraphicFrame? GraphicFrame
  {
    get;
    set;
  }
  
  public ConnectionShape? ConnectionShape
  {
    get;
    set;
  }
  
  public Picture? Picture
  {
    get;
    set;
  }
  
}
