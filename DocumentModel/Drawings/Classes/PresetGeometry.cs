namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Preset geometry.
/// </summary>
public class PresetGeometry: ModelElement
{
  /// <summary>
  ///   Preset IShape
  /// </summary>
  public ShapeKind? Preset { get; set; }

  /// <summary>
  ///   IList of IShape Adjust Values.
  /// </summary>
  public AdjustValueList? AdjustValueList { get; set; }
}
