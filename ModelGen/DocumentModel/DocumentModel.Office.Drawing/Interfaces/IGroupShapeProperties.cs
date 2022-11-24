namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the GroupShapeProperties Class.
/// </summary>
public interface IGroupShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
