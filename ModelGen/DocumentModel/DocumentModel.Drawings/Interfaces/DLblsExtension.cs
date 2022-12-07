namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public interface DLblsExtension
{
  public ChartText2? ChartText { get ; set; }
  
  public DataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public ShapeProperties8? ShapeProperties { get ; set; }
  
  public Layout2? Layout { get ; set; }
  
  public LeaderLines2? LeaderLines { get ; set; }
  
}
