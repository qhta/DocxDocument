namespace DocumentModel.Drawing;

/// <summary>
/// Preset geometry.
/// </summary>
public interface IPresetGeometry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Shape
  /// </summary>
  public DocumentModel.Drawing.ShapeTypeKind? Preset { get ; set; }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? AdjustValueList { get ; set; }
  
}
