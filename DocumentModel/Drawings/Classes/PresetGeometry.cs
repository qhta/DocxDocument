namespace DocumentModel.Drawings;

/// <summary>
///   Preset geometry.
/// </summary>
public class PresetGeometry: ModelElement
{
  /// <summary>
  ///   Preset Shape
  /// </summary>
  public ShapeKind? Preset { get; set; }

  /// <summary>
  ///   List of Shape Adjust Values.
  /// </summary>
  public AdjustValueList? AdjustValueList { get; set; }
}