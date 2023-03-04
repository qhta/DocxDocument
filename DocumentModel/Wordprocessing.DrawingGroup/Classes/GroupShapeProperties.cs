using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
///   Defines the GroupShapeProperties Class.
/// </summary>
public class GroupShapeProperties
{
  /// <summary>
  ///   Black and White Mode
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  ///   2D Transform for Grouped Objects.
  /// </summary>
  public TransformGroup? TransformGroup { get; set; }

  public Boolean? NoFill { get; set; }

  public SolidFill? SolidFill { get; set; }

  public GradientFill? GradientFill { get; set; }

  public BlipFill? BlipFill { get; set; }

  public PatternFill? PatternFill { get; set; }

  public Boolean? GroupFill { get; set; }

  public EffectList? EffectList { get; set; }

  public EffectDag? EffectDag { get; set; }

  public Scene3DType? Scene3DType { get; set; }

  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
}