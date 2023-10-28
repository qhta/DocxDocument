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
  
  public DMDC13.ChartText? ChartText { get; set; }
  
  public DMDC13.DataLabelFieldTable? DataLabelFieldTable { get; set; }
  
  public DMDC13.ShowDataLabelsRange? ShowDataLabelsRange { get; set; }
  
  public DMDC13.ShapeProperties? ShapeProperties { get; set; }
  
  public DMDC13.Layout? Layout { get; set; }
  
  public DMDC13.ShowLeaderLines? ShowLeaderLines { get; set; }
  
  public DMDC13.LeaderLines? LeaderLines { get; set; }
  
}
