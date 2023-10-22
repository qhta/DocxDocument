namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Plot data and formatting.
/// </summary>
public partial class PlotArea
{
  
  /// <summary>
  ///   Layout.
  /// </summary>
  public DocumentModel.Drawings.Charts.Layout? Layout { get; set; }
  
  public DocumentModel.Drawings.Charts.DataTable? DataTable { get; set; }
  
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
