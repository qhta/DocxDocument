namespace DocumentModel.Drawing;

/// <summary>
/// Preset Text Warp.
/// </summary>
public interface IPresetTextWrap // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  public DocumentModel.Drawing.TextShapeKind? Preset { get ; set; }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public DocumentModel.Drawing.IAdjustValueList? AdjustValueList { get ; set; }
  
}
