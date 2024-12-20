namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ShapePropertiesExtension Class.
/// </summary>
public class ShapePropertiesExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }

  public Fill? HiddenFillProperties { get; set; }

  public HiddenLineProperties? HiddenLineProperties { get; set; }

  public HiddenEffectsProperties? HiddenEffectsProperties { get; set; }

  public HiddenScene3D? HiddenScene3D { get; set; }

  public HiddenShape3D? HiddenShape3D { get; set; }

  public bool? ShadowObscured { get; set; }
}