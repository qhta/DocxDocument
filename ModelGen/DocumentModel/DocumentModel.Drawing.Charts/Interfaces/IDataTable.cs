namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Data Table.
/// </summary>
public interface IDataTable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Horizontal Border.
  /// </summary>
  public IShowHorizontalBorder? ShowHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Show Vertical Border.
  /// </summary>
  public IShowVerticalBorder? ShowVerticalBorder { get ; set; }
  
  /// <summary>
  /// Show Outline Border.
  /// </summary>
  public IShowOutlineBorder? ShowOutlineBorder { get ; set; }
  
  /// <summary>
  /// Show Legend Keys.
  /// </summary>
  public IShowKeys? ShowKeys { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
