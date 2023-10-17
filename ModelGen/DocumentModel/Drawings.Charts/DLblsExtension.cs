namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DLblsExtension Class.
/// </summary>
public partial class DLblsExtension
{
  
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.ChartText? ChartText { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabelFieldTable? DataLabelFieldTable { get; set; }
  
  public DocumentModel.Drawings.Charts.ShowDataLabelsRange? ShowDataLabelsRange { get; set; }
  
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.Layout? Layout { get; set; }
  
  public DocumentModel.Drawings.Charts.ShowLeaderLines? ShowLeaderLines { get; set; }
  
  public DocumentModel.Drawings.Charts.LeaderLines? LeaderLines { get; set; }
  
}
