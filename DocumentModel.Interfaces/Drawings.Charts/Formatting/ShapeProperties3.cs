namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ShapeProperties Class.
/// </summary>
public interface ShapeProperties3
{
  /// <summary>
  ///   Black and White Mode
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }
  /// <summary>
  ///   2D Transform for Individual Objects.
  /// </summary>
  public Transform2D? Transform2D { get; set; }

  /// <summary>
  /// Custom geometry
  /// </summary>
  public CustomGeometry? CustomGeometry { get; set; }

  /// <summary>
  /// Preset geometry
  /// </summary>
  public PresetGeometry? PresetGeometry { get; set; }

  /// <summary>
  /// Fill properties
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  /// Outline properties
  /// </summary>
  public LineProperties? Outline { get; set; }

  /// <summary>
  /// Effect list
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  /// Effect DAG
  /// </summary>
  public EffectDag? EffectDag { get; set; }

  /// <summary>
  /// 3D scene type
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }

  /// <summary>
  /// 3D shape type
  /// </summary>
  public Shape3DType? Shape3DType { get; set; }

  /// <summary>
  /// Shape properties extension list
  /// </summary>
  public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get; set; }
}