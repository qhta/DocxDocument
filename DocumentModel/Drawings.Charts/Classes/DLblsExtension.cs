namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public partial class DLblsExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.ChartText3? ChartText { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabelFieldTable? DataLabelFieldTable { get; set; }
  
  public Boolean? ShowDataLabelsRange { get; set; }
  
  public DocumentModel.Drawings.Charts.ShapeProperties3? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.Layout3? Layout { get; set; }
  
  public Boolean? ShowLeaderLines { get; set; }
  
  public DocumentModel.Drawings.Charts.LeaderLines3? LeaderLines { get; set; }
  
}
