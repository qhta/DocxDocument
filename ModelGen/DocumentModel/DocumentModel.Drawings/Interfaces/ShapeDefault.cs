namespace DocumentModel.Drawings;

/// <summary>
/// Shape Default.
/// </summary>
public interface ShapeDefault
{
  public ShapeProperties4? ShapeProperties { get ; set; }
  
  public BodyProperties? BodyProperties { get ; set; }
  
  public ListStyle? ListStyle { get ; set; }
  
  public ShapeStyle2? ShapeStyle { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
