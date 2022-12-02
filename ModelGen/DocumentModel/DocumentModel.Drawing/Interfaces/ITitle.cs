namespace DocumentModel.Drawing;

/// <summary>
/// Title.
/// </summary>
public interface ITitle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Text.
  /// </summary>
  public IChartText? ChartText { get ; set; }
  
  /// <summary>
  /// Layout.
  /// </summary>
  public ILayout? Layout { get ; set; }
  
  /// <summary>
  /// Overlay.
  /// </summary>
  public Boolean? Overlay { get ; set; }
  
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
