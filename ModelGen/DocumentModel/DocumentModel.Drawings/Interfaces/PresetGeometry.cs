namespace DocumentModel.Drawings;

/// <summary>
/// Preset geometry.
/// </summary>
public interface PresetGeometry
{
  /// <summary>
  /// Preset Shape
  /// </summary>
  public DocumentModel.Drawings.ShapeKind? Preset { get ; set; }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  public DocumentModel.Drawings.AdjustValueList? AdjustValueList { get ; set; }
  
}
