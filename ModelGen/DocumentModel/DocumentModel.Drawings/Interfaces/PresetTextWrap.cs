namespace DocumentModel.Drawings;

/// <summary>
/// Preset Text Warp.
/// </summary>
public interface PresetTextWrap
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  public DocumentModel.Drawings.TextShapeKind? Preset { get ; set; }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public DocumentModel.Drawings.AdjustValueList? AdjustValueList { get ; set; }
  
}
