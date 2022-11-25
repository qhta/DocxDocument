namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the GroupShapeProperties Class.
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
