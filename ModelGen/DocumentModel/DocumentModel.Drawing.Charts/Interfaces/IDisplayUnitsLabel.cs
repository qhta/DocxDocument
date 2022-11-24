namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Display Units Label.
/// </summary>
public interface IDisplayUnitsLabel // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public ITextProperties? TextProperties { get ; set; }
  
}
