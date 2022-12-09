namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public interface DLblsExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ChartText2? ChartText { get ; set; }
  
  public DataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public Boolean? ShowDataLabelsRange { get ; set; }
  
  public ShapeProperties2? ShapeProperties { get ; set; }
  
  public Layout2? Layout { get ; set; }
  
  public Boolean? ShowLeaderLines { get ; set; }
  
  public LeaderLines2? LeaderLines { get ; set; }
  
}
