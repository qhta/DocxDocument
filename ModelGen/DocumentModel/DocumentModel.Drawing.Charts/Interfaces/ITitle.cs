namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Title.
/// </summary>
public interface ITitle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Text.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartText? ChartText { get ; set; }
  
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawing.Charts.ILayout? Layout { get ; set; }
  
  /// <summary>
  /// Overlay.
  /// </summary>
  public System.Boolean? Overlay { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.ITextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
