namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Data Table.
/// </summary>
public partial class DataTable
{
  
  /// <summary>
  ///   Show Horizontal Border.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShowHorizontalBorder? ShowHorizontalBorder { get; set; }
  
  
  /// <summary>
  ///   Show Vertical Border.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShowVerticalBorder? ShowVerticalBorder { get; set; }
  
  
  /// <summary>
  ///   Show Outline Border.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShowOutlineBorder? ShowOutlineBorder { get; set; }
  
  
  /// <summary>
  ///   Show Legend Keys.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShowKeys? ShowKeys { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Text Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
