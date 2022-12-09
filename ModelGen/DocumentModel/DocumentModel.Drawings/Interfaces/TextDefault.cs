namespace DocumentModel.Drawings;

/// <summary>
/// Text Default.
/// </summary>
public interface TextDefault
{
  public ShapeProperties4? ShapeProperties { get ; set; }
  
  public BodyProperties? BodyProperties { get ; set; }
  
  public ListStyle? ListStyle { get ; set; }
  
  public ShapeStyle2? ShapeStyle { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
