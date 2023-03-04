using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
///   Defines the ShapeProperties Class.
/// </summary>
public class ShapeProperties
{
  /// <summary>
  ///   Black and White Mode
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  ///   2D Transform for Individual Objects.
  /// </summary>
  public DocumentModel.Drawings.Transform2D? Transform2D { get; set; }

  public CustomGeometry? CustomGeometry { get; set; }

  public PresetGeometry? PresetGeometry { get; set; }

  public Boolean? NoFill { get; set; }

  public SolidFill? SolidFill { get; set; }

  public GradientFill? GradientFill { get; set; }

  public BlipFill? BlipFill { get; set; }

  public PatternFill? PatternFill { get; set; }

  public Boolean? GroupFill { get; set; }

  public Outline? Outline { get; set; }

  public EffectList? EffectList { get; set; }

  public EffectDag? EffectDag { get; set; }

  public Scene3DType? Scene3DType { get; set; }

  public Shape3DType? Shape3DType { get; set; }

  public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get; set; }
}