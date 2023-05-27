namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ShapeProperties Class.
/// </summary>
public class ShapeProperties3: ModelElement
{
  /// <summary>
  ///   Black and White Mode
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  ///   2D Transform for Individual Objects.
  /// </summary>
  public Transform2D? Transform2D { get; set; }

  public CustomGeometry? CustomGeometry { get; set; }

  public PresetGeometry? PresetGeometry { get; set; }

  public Fill? Fill { get; set; }

  public Outline? Outline { get; set; }

  public EffectList? EffectList { get; set; }

  public EffectDag? EffectDag { get; set; }

  public Scene3DType? Scene3DType { get; set; }

  public Shape3DType? Shape3DType { get; set; }

  public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get; set; }
}