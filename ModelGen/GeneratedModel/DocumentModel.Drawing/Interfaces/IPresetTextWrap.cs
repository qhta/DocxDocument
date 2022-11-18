namespace DocumentModel.Drawing;

/// <summary>
/// Preset Text Warp.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IAdjustValueList))]
public interface IPresetTextWrap // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  public TextShape? Preset { get ; set; }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public IAdjustValueList? AdjustValueList { get ; set; }
  
}
