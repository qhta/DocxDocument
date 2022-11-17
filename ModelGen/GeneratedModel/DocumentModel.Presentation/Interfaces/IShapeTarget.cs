namespace DocumentModel.Presentation;

public interface IShapeTarget // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? ShapeId { get ; set; }
  
  public IBackgroundAnimation? BackgroundAnimation { get ; set; }
  
  public ISubShape? SubShape { get ; set; }
  
  public IOleChartElement? OleChartElement { get ; set; }
  
  public ITextElement? TextElement { get ; set; }
  
  public IGraphicElement? GraphicElement { get ; set; }
  
}
