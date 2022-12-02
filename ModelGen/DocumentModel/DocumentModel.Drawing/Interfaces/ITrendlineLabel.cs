namespace DocumentModel.Drawing;

/// <summary>
/// Trendline Label.
/// </summary>
public interface ITrendlineLabel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Layout.
  /// </summary>
  public ILayout? Layout { get ; set; }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public IChartText? ChartText { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
