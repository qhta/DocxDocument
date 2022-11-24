namespace DocumentModel.Drawing;

/// <summary>
/// Visual Group Shape Properties.
/// </summary>
public interface IVisualGroupShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteModeValues? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// 2D Transform for Grouped Objects.
  /// </summary>
  public ITransformGroup? TransformGroup { get ; set; }
  
}
