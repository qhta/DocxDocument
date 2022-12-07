namespace DocumentModel.Drawings;

/// <summary>
/// Preset Text Warp.
/// </summary>
public interface PresetTextWrap
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  public TextShapeKind? Preset { get ; set; }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public AdjustValueList? AdjustValueList { get ; set; }
  
}
