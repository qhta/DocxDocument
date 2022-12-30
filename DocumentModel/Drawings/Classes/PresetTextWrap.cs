namespace DocumentModel.Drawings;

/// <summary>
/// Preset Text Warp.
/// </summary>
public partial class PresetTextWrap
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  public DocumentModel.Drawings.TextShapeKind? Preset { get; set; }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public DocumentModel.Drawings.AdjustValueList? AdjustValueList { get; set; }
  
}
