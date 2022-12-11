namespace DocumentModel.Drawings;

/// <summary>
/// Text Default.
/// </summary>
public interface TextDefault
{
  public ShapeProperties? ShapeProperties { get ; set; }
  
  public BodyProperties? BodyProperties { get ; set; }
  
  public ListStyle? ListStyle { get ; set; }
  
  public ShapeStyle? ShapeStyle { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
