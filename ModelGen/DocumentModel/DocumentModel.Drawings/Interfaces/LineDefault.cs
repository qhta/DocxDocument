namespace DocumentModel.Drawings;

/// <summary>
/// Line Default.
/// </summary>
public interface LineDefault
{
  public ShapeProperties4? ShapeProperties { get ; set; }
  
  public BodyProperties? BodyProperties { get ; set; }
  
  public ListStyle? ListStyle { get ; set; }
  
  public ShapeStyle2? ShapeStyle { get ; set; }
  
  public ExtensionList4? ExtensionList { get ; set; }
  
}
