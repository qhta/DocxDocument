namespace DocumentModel.Drawings;

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
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public TextProperties2? TextProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList { get ; set; }
  
}
