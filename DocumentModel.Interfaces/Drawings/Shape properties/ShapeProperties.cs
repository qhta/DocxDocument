namespace DocumentModel.Drawings;

/// <summary>
///   Represents visual properties for a shape, including geometry, fill, outline, effects, 2D and 3D transforms, and extension lists.
/// </summary>
public interface ShapeProperties
{
  /// <summary>
  ///   Black and white rendering mode for the shape.
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  ///   2D transformation applied to the shape.
  /// </summary>
  public Transform2D? Transform2D { get; set; }

  /// <summary>
  ///   Custom geometry definition for the shape.
  /// </summary>
  public CustomGeometry? CustomGeometry { get; set; }

  /// <summary>
  ///   Preset geometry definition for the shape.
  /// </summary>
  public PresetGeometry? PresetGeometry { get; set; }

  /// <summary>
  ///   Fill formatting for the shape.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  ///   Outline formatting for the shape.
  /// </summary>
  public LineProperties? Outline { get; set; }

  /// <summary>
  ///   List of effects applied to the shape.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  ///   Effect DAG (Directed Acyclic Graph) for advanced effect composition.
  /// </summary>
  public EffectDag? EffectDag { get; set; }

  /// <summary>
  ///   3D scene properties for the shape.
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }

  /// <summary>
  ///   3D shape properties.
  /// </summary>
  public Shape3DType? Shape3DType { get; set; }

  /// <summary>
  ///   Extension list for additional shape properties.
  /// </summary>
  public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get; set; }
}