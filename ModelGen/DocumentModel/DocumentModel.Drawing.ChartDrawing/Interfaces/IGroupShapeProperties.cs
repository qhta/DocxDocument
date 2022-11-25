namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Group Shape Properties.
/// </summary>
public interface IGroupShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public DocumentModel.Drawing.BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Grouped Objects.
  /// </summary>
  public DocumentModel.Drawing.ITransformGroup? TransformGroup { get ; set; }
  
}
