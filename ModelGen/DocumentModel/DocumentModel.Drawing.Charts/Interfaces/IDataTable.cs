namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Data Table.
/// </summary>
public interface IDataTable // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Show Horizontal Border.
  /// </summary>
  public System.Boolean? ShowHorizontalBorder { get ; set; }
  
  /// <summary>
  /// Show Vertical Border.
  /// </summary>
  public System.Boolean? ShowVerticalBorder { get ; set; }
  
  /// <summary>
  /// Show Outline Border.
  /// </summary>
  public System.Boolean? ShowOutlineBorder { get ; set; }
  
  /// <summary>
  /// Show Legend Keys.
  /// </summary>
  public System.Boolean? ShowKeys { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public DocumentModel.Drawing.Charts.ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
