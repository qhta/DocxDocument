namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Plot data and formatting.
/// </summary>
public partial class PlotArea
{
  
  /// <summary>
  ///   Layout.
  /// </summary>
  public DMDC.Layout? Layout { get; set; }
  
  public DMDC.DataTable? DataTable { get; set; }
  
  public DMDC.ShapeProperties? ShapeProperties { get; set; }
  
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
