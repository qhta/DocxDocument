namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Shape Properties.
/// </summary>
[OpenXmlType(typeof(DXDD.ShapeProperties))]
/// <summary>
/// Represents the Shape Properties.
/// </summary>
public class ShapeProperties: ModelElement<DXDD.ShapeProperties>
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
  /// Custom Geometry.
  /// </summary>
  public CustomGeometry? CustomGeometry { get; set; }
  /// <summary>
  /// Preset Geometry.
  /// </summary>
  public PresetGeometry? PresetGeometry { get; set; }
  /// <summary>
  /// Fill.
  /// </summary>
  public Fill? Fill { get; set; }
  /// <summary>
  /// Outline.
  /// </summary>
  public LineProperties? Outline { get; set; }
  /// <summary>
  /// Effect List.
  /// </summary>
  public EffectList? EffectList { get; set; }
  /// <summary>
  /// Effect Dag.
  /// </summary>
  public EffectDag? EffectDag { get; set; }
  /// <summary>
  /// Scene3 DType.
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }
  /// <summary>
  /// Shape3 DType.
  /// </summary>
  public Shape3DType? Shape3DType { get; set; }
  /// <summary>
  /// Shape Properties Extension List.
  /// </summary>
  public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get; set; }
}

