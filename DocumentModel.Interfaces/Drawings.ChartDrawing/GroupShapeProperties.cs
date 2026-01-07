namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Represents properties for a group shape, including fill, effects, 2D and 3D transforms, and additional extensions.
/// </summary>
public interface GroupShapeProperties
{
  /// <summary>
  /// Black and white rendering mode for the group shape.
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  /// Gets or sets the 2D transform settings for grouped objects.
  /// </summary>
  public TransformGroup? TransformGroup { get; set; }

  /// <summary>
  /// Fill properties for the group shape.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  /// List of effects applied to the group shape.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  /// Effect directed acyclic graph, defining the structure and relationships of effects.
  /// </summary>
  public EffectDag? EffectDag { get; set; }

  /// <summary>
  /// Gets or sets the 3D scene type, specifying the 3D environment for the group shape.
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }

  /// <summary>
  /// Extension list for additional group shape properties.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}