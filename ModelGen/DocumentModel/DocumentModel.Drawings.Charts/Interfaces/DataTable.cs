namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Data Table.
/// </summary>
public interface DataTable
{
  /// <summary>
  /// Show Horizontal Border.
  /// </summary>
  public Boolean? ShowHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Show Vertical Border.
  /// </summary>
  public Boolean? ShowVerticalBorder { get ; set; }
  
  /// <summary>
  /// Show Outline Border.
  /// </summary>
  public Boolean? ShowOutlineBorder { get ; set; }
  
  /// <summary>
  /// Show Legend Keys.
  /// </summary>
  public Boolean? ShowKeys { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
