namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public interface DLblsExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ChartText? ChartText { get ; set; }
  
  public DataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public Boolean? ShowDataLabelsRange { get ; set; }
  
  public ShapeProperties? ShapeProperties { get ; set; }
  
  public Layout? Layout { get ; set; }
  
  public Boolean? ShowLeaderLines { get ; set; }
  
  public LeaderLines? LeaderLines { get ; set; }
  
}
