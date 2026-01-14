namespace DocumentModel.Drawings;

/// <summary>
/// Represents a bevel effect, defining the width, height, and preset style for 3D effects on shapes.
/// </summary>
public class BevelType: ModelElement
{
  /// <summary>
  /// Width of the bevel.
  /// </summary>
  public Int64? Width { get; set; }

  /// <summary>
  /// Height of the bevel.
  /// </summary>
  public Int64? Height { get; set; }

  /// <summary>
  /// Preset bevel style.
  /// </summary>
  public BevelPresetKind? Preset { get; set; }
}