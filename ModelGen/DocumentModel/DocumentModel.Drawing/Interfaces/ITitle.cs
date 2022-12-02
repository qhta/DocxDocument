namespace DocumentModel.Drawing;

/// <summary>
/// Title.
/// </summary>
public interface ITitle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Text.
  /// </summary>
  public DocumentModel.Drawing.IChartText? ChartText { get ; set; }
  
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawing.ILayout? Layout { get ; set; }
  
  /// <summary>
  /// Overlay.
  /// </summary>
  public System.Boolean? Overlay { get ; set; }
  
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
