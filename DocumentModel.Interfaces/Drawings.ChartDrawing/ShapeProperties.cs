namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes visual and formatting properties for a shape in chart drawings, including black and white mode, transformations, geometry, fill, outline, effects, 3D settings, and extension data.
/// </summary>
public interface ShapeProperties
{
  /// <summary>
  /// Specifies the black and white rendering mode for the shape.
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  /// 2D transformation settings for positioning and scaling the shape.
  /// </summary>
  public Transform2D? Transform2D { get; set; }

  /// <summary>
  /// Custom geometry definition for the shape.
  /// </summary>
  public CustomGeometry? CustomGeometry { get; set; }

  /// <summary>
  /// Preset geometry definition for the shape.
  /// </summary>
  public PresetGeometry? PresetGeometry { get; set; }

  /// <summary>
  /// Fill formatting applied to the shape.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  /// Outline formatting and properties for the shape.
  /// </summary>
  public LineProperties? Outline { get; set; }

  /// <summary>
  /// Collection of effects applied to the shape.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  /// Directed acyclic graph representing the structure and relationships of effects.
  /// </summary>
  public EffectDag? EffectDag { get; set; }

  /// <summary>
  /// 3D scene type specifying the environment for the shape.
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }

  /// <summary>
  /// 3D shape type specifying the geometry for the shape in three dimensions.
  /// </summary>
  public Shape3DType? Shape3DType { get; set; }

  /// <summary>
  /// Extension list for additional or future shape properties.
  /// </summary>
  public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get; set; }
}