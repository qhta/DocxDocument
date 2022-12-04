namespace DocumentModel.Drawings;

/// <summary>
/// Preset geometry.
/// </summary>
public class PresetGeometry
{
  /// <summary>
  /// Preset Shape
  /// </summary>
  public ShapeKind1? Preset
  {
    get;
    set;
  }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  public AdjustValueList? AdjustValueList
  {
    get;
    set;
  }
  
}
