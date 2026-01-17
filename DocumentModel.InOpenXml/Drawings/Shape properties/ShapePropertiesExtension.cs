namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension for shape properties, providing additional or hidden formatting and configuration options.
/// </summary>
public class ShapePropertiesExtension: ModelElement<DXD.ShapePropertiesExtension>, IExtension
{

  /// <summary>
  ///   Hidden fill formatting properties.
  /// </summary>
  public Fill? HiddenFillProperties { get; set; }

  /// <summary>
  ///   Hidden line formatting properties.
  /// </summary>
  public HiddenLineProperties? HiddenLineProperties { get; set; }

  /// <summary>
  ///   Hidden effects formatting properties.
  /// </summary>
  public HiddenEffectsProperties? HiddenEffectsProperties { get; set; }

  /// <summary>
  ///   Hidden 3D scene properties.
  /// </summary>
  public HiddenScene3D? HiddenScene3D { get; set; }

  /// <summary>
  ///   Hidden 3D shape properties.
  /// </summary>
  public HiddenShape3D? HiddenShape3D { get; set; }

  /// <summary>
  ///   Indicates whether the shadow is obscured.
  /// </summary>
  public bool? ShadowObscured { get; set; }

  public string? UriString { get; set; }
}