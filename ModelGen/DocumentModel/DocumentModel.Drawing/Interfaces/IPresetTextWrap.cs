namespace DocumentModel.Drawing;

/// <summary>
/// Preset Text Warp.
/// </summary>
public interface IPresetTextWrap // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  public TextShapeKind? Preset { get ; set; }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public IAdjustValueList? AdjustValueList { get ; set; }
  
}
