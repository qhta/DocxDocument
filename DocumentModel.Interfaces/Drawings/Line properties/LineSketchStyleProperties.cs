namespace DocumentModel.Drawings;

/// <summary>
///   Represents sketch style properties for a line, including geometry, type, and seed information.
/// </summary>
public interface LineSketchStyleProperties : OfficeArtExtendableElement
{
  /// <summary>
  ///   Sketch style definition identifier.
  /// </summary>
  public UInt32? Sd { get; set; }

  /// <summary>
  ///   Custom geometry used for the sketch style.
  /// </summary>
  public CustomGeometry? CustomGeometry { get; set; }

  /// <summary>
  ///   Preset geometry used for the sketch style.
  /// </summary>
  public PresetGeometry? PresetGeometry { get; set; }

  /// <summary>
  ///   Additional properties for the sketch style type.
  /// </summary>
  public LineSketchTypeProperties? LineSketchTypeProperties { get; set; }

  /// <summary>
  ///   Seed value for generating the sketch style.
  /// </summary>
  public string? LineSketchSeed { get; set; }
}