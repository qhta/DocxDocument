namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes properties for a group shape in chart drawings, including black and white rendering, 2D and 3D transforms, fill, effects, and extension data.
/// </summary>
public interface GroupShapeProperties
{
  /// <summary>
  /// Specifies the black and white rendering mode for the group shape.
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  /// 2D transformation settings for positioning and scaling grouped objects.
  /// </summary>
  public TransformGroup? TransformGroup { get; set; }

  /// <summary>
  /// Fill formatting applied to the group shape.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  /// Collection of effects applied to the group shape.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  /// Directed acyclic graph representing the structure and relationships of effects.
  /// </summary>
  public EffectDag? EffectDag { get; set; }

  /// <summary>
  /// 3D scene type specifying the environment for the group shape.
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }

  /// <summary>
  /// Extension list for additional or future group shape properties.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}