namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
public interface DLblExtension
{
  public DataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public ShapeProperties8? ShapeProperties { get ; set; }
  
  public Layout2? Layout { get ; set; }
  
}
