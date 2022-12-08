namespace DocumentModel.Drawings;

/// <summary>
/// Shape Default.
/// </summary>
public interface ShapeDefault
{
  public ShapeProperties8? ShapeProperties { get ; set; }
  
  public BodyProperties? BodyProperties { get ; set; }
  
  public ListStyle? ListStyle { get ; set; }
  
  public ShapeStyle1? ShapeStyle { get ; set; }
  
  public ExtensionList1? ExtensionList { get ; set; }
  
}
