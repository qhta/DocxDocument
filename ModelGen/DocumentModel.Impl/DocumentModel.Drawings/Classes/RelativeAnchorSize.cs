namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public FromAnchor? FromAnchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public ToAnchor? ToAnchor
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
