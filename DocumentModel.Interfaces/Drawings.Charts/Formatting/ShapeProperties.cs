namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ShapeProperties Class.
/// </summary>
public interface ShapeProperties
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
  /// Custom Geometry
  /// </summary>
  public CustomGeometry? CustomGeometry { get; set; }

  /// <summary>
  /// Preset Geometry
  /// </summary>
  public PresetGeometry? PresetGeometry { get; set; }

  /// <summary>
  /// Fill Properties
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  /// Outline Properties
  /// </summary>
  public LineProperties? Outline { get; set; }

  /// <summary>
  /// Effect List
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  /// Effect DAG
  /// </summary>
  public EffectDag? EffectDag { get; set; }

  /// <summary>
  /// 3D Scene Type
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }

  /// <summary>
  /// 3D Shape Type
  /// </summary>
  public Shape3DType? Shape3DType { get; set; }

  /// <summary>
  /// Shape Properties Extension List
  /// </summary>
  public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get; set; }
}