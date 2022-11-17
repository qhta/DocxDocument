namespace DocumentModel.Vml;

public interface IStroke // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Id { get ; set; }
  
  public ITrueFalseValue? On { get ; set; }
  
  public string? Weight { get ; set; }
  
  public string? Color { get ; set; }
  
  public string? Opacity { get ; set; }
  
  public StrokeLineStyle? LineStyle { get ; set; }
  
  public string? Miterlimit { get ; set; }
  
  public StrokeJoinStyle? JoinStyle { get ; set; }
  
  public StrokeEndCap? EndCap { get ; set; }
  
  public string? DashStyle { get ; set; }
  
  public StrokeFillType? FillType { get ; set; }
  
  public string? Source { get ; set; }
  
  public ImageAspect? ImageAspect { get ; set; }
  
  public string? ImageSize { get ; set; }
  
  public ITrueFalseValue? ImageAlignShape { get ; set; }
  
  public string? Color2 { get ; set; }
  
  public StrokeArrow? StartArrow { get ; set; }
  
  public StrokeArrowWidth? StartArrowWidth { get ; set; }
  
  public StrokeArrowLength? StartArrowLength { get ; set; }
  
  public StrokeArrow? EndArrow { get ; set; }
  
  public StrokeArrowWidth? EndArrowWidth { get ; set; }
  
  public StrokeArrowLength? EndArrowLength { get ; set; }
  
  public string? Href { get ; set; }
  
  public string? AlternateImageReference { get ; set; }
  
  public string? Title { get ; set; }
  
  public ITrueFalseValue? ForceDash { get ; set; }
  
  public string? RelationshipId { get ; set; }
  
  public ITrueFalseValue? Insetpen { get ; set; }
  
  public ILeftStroke? LeftStroke { get ; set; }
  
  public ITopStroke? TopStroke { get ; set; }
  
  public IRightStroke? RightStroke { get ; set; }
  
  public IBottomStroke? BottomStroke { get ; set; }
  
  public IColumnStroke? ColumnStroke { get ; set; }
  
}
