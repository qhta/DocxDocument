namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Data Table.
/// </summary>
public partial class DataTable
{
  
  /// <summary>
  ///   Show Horizontal Border.
  /// </summary>
  public DMDC.ShowHorizontalBorder? ShowHorizontalBorder { get; set; }
  
  
  /// <summary>
  ///   Show Vertical Border.
  /// </summary>
  public DMDC.ShowVerticalBorder? ShowVerticalBorder { get; set; }
  
  
  /// <summary>
  ///   Show Outline Border.
  /// </summary>
  public DMDC.ShowOutlineBorder? ShowOutlineBorder { get; set; }
  
  
  /// <summary>
  ///   Show Legend Keys.
  /// </summary>
  public DMDC.ShowKeys? ShowKeys { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DMDC.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Text Properties.
  /// </summary>
  public DMDC.TextProperties? TextProperties { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
