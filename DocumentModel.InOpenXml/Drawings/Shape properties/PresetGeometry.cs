namespace DocumentModel.Drawings;

/// <summary>
///   Represents a preset geometry for a shape, including the preset type and optional adjustment values.
/// </summary>
public class PresetGeometry: ModelElement<DXD.PresetGeometry>
{
  /// <summary>
  ///   Preset shape type.
  /// </summary>
  public ShapeKind? Preset { get; set; }

  /// <summary>
  ///   List of adjustment values for the preset shape.
  /// </summary>
  public AdjustValueList? AdjustValueList { get; set; }
}