namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the visual and shape properties for a chart element.
///   This interface allows configuration of fill, outline, effects, geometry, and 3D settings to control the appearance of chart components such as data points, labels, or the chart area.
/// </summary>
public interface ChartShapeProperties
{
  /// <summary>
  ///   Black and white rendering mode for the chart element.
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode { get; set; }

  /// <summary>
  ///   2D transformation settings for positioning, scaling, and rotating the chart element.
  /// </summary>
  public Transform2D? Transform2D { get; set; }

  /// <summary>
  ///   Custom geometry definition for the chart element's shape.
  /// </summary>
  public CustomGeometry? CustomGeometry { get; set; }

  /// <summary>
  ///   Preset geometry type for the chart element's shape.
  /// </summary>
  public PresetGeometry? PresetGeometry { get; set; }

  /// <summary>
  ///   Fill formatting for the chart element, such as solid, gradient, or pattern fill.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  ///   Outline or border formatting for the chart element.
  /// </summary>
  public LineProperties? Outline { get; set; }

  /// <summary>
  ///   List of visual effects applied to the chart element, such as shadows or glows.
  /// </summary>
  public EffectList? EffectList { get; set; }

  /// <summary>
  ///   Complex effect container for advanced visual effects.
  /// </summary>
  public EffectDag? EffectDag { get; set; }

  /// <summary>
  ///   3D scene settings for the chart element.
  /// </summary>
  public Scene3DType? Scene3DType { get; set; }

  /// <summary>
  ///   3D shape settings for the chart element.
  /// </summary>
  public Shape3DType? Shape3DType { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional shape customization.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}