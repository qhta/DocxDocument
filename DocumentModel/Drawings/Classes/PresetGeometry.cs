namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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