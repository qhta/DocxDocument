namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public interface DLblsExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.ChartText? ChartText { get ; set; }
  
  public DocumentModel.Drawings13.Charts.DataLabelFieldTable? DataLabelFieldTable { get ; set; }
  
  public Boolean? ShowDataLabelsRange { get ; set; }
  
  public DocumentModel.Drawings13.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawings13.Charts.Layout? Layout { get ; set; }
  
  public Boolean? ShowLeaderLines { get ; set; }
  
  public DocumentModel.Drawings13.Charts.LeaderLines? LeaderLines { get ; set; }
  
}
