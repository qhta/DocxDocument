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
  public DocumentModel.BaseTypes.ModelElement? AdjustValueList { get ; set; }
  
}
