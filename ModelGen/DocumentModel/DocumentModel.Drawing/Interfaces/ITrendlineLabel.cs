namespace DocumentModel.Drawing;

/// <summary>
/// Trendline Label.
/// </summary>
public interface ITrendlineLabel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawing.ILayout? Layout { get ; set; }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public DocumentModel.Drawing.IChartText? ChartText { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public DocumentModel.Drawing.INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawing.ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
