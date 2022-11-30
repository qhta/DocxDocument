namespace DocumentModel.Drawing;

/// <summary>
/// Preset geometry.
/// </summary>
public interface IPresetGeometry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Shape
  /// </summary>
  public DocumentModel.Drawing.ShapeKind? Preset { get ; set; }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  public DocumentModel.Drawing.IAdjustValueList? AdjustValueList { get ; set; }
  
}
