namespace DocumentModel.Vml;

public interface IFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Id { get ; set; }
  
  public FillType? Type { get ; set; }
  
  public ITrueFalseValue? On { get ; set; }
  
  public string? Color { get ; set; }
  
  public string? Opacity { get ; set; }
  
  public string? Color2 { get ; set; }
  
  public string? Source { get ; set; }
  
  public string? Href { get ; set; }
  
  public string? AlternateImageReference { get ; set; }
  
  public string? Size { get ; set; }
  
  public string? Origin { get ; set; }
  
  public string? Position { get ; set; }
  
  public ImageAspect? Aspect { get ; set; }
  
  public string? Colors { get ; set; }
  
  public decimal? Angle { get ; set; }
  
  public ITrueFalseValue? AlignShape { get ; set; }
  
  public string? Focus { get ; set; }
  
  public string? FocusSize { get ; set; }
  
  public string? FocusPosition { get ; set; }
  
  public FillMethod? Method { get ; set; }
  
  public ITrueFalseValue? DetectMouseClick { get ; set; }
  
  public string? Title { get ; set; }
  
  public string? Opacity2 { get ; set; }
  
  public ITrueFalseValue? Recolor { get ; set; }
  
  public ITrueFalseValue? Rotate { get ; set; }
  
  public string? RelationshipId { get ; set; }
  
  public IFillExtendedProperties? FillExtendedProperties { get ; set; }
  
}
