namespace DocumentModel.Vml.Office;

public interface IBottomStroke // : DocumentFormat.OpenXml.Vml.Office.StrokeChildType
{
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
  public ITrueFalseValue? On { get ; set; }
  
  public string? Weight { get ; set; }
  
  public string? Color { get ; set; }
  
  public string? Color2 { get ; set; }
  
  public string? Opacity { get ; set; }
  
  public StrokeLineStyle? LineStyle { get ; set; }
  
  public decimal? MiterLimit { get ; set; }
  
  public StrokeJoinStyle? JoinStyle { get ; set; }
  
  public StrokeEndCap? EndCap { get ; set; }
  
  public string? DashStyle { get ; set; }
  
  public ITrueFalseValue? InsetPen { get ; set; }
  
  public FillType? FillType { get ; set; }
  
  public string? Source { get ; set; }
  
  public ImageAspect? ImageAspect { get ; set; }
  
  public string? ImageSize { get ; set; }
  
  public ITrueFalseValue? ImageAlignShape { get ; set; }
  
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
  
}
