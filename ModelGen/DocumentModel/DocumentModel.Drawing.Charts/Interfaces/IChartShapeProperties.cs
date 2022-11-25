namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ChartShapeProperties Class.
/// </summary>
public interface IChartShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public DocumentModel.Drawing.BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  public DocumentModel.Drawing.ITransform2D? Transform2D { get ; set; }
  
}
