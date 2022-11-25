namespace DocumentModel.Drawing;

/// <summary>
/// Visual Group Shape Properties.
/// </summary>
public interface IVisualGroupShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
