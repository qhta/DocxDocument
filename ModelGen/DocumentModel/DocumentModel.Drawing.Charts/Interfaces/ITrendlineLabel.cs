namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Trendline Label.
/// </summary>
public interface ITrendlineLabel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawing.Charts.ILayout? Layout { get ; set; }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartText? ChartText { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public DocumentModel.Drawing.Charts.INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.ITextBodyType? TextProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
