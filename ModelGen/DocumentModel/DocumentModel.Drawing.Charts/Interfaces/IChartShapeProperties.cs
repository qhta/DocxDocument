namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ChartShapeProperties Class.
/// </summary>
public interface IChartShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteModeValues? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  public ITransform2D? Transform2D { get ; set; }
  
}
