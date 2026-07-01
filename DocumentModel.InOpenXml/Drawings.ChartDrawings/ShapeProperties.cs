namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the ShapeProperties Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.ShapeProperties))]
[DataContract]
[XmlRoot("ShapeProperties", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class ShapeProperties : ModelElement<DXO16DCD.ShapeProperties>
{
  /// <summary>
  /// Specifies the black white mode.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ShapeProperties.BlackWhiteMode))]
  public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

  private BlackWhiteMode? _BlackWhiteMode;
  /// <summary>
  /// Specifies the transform2d.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ShapeProperties.Transform2D))]
  public Drawings.Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

  private Drawings.Transform2D? _Transform2D;
  /// <summary>
  /// Specifies the custom geometry.
  /// </summary>
  public CustomGeometry? CustomGeometry { get => _CustomGeometry; set => UpdateField(ref _CustomGeometry, value, nameof(CustomGeometry)); }

  private CustomGeometry? _CustomGeometry;
  /// <summary>
  /// Specifies the preset geometry.
  /// </summary>
  public PresetGeometry? PresetGeometry { get => _PresetGeometry; set => UpdateField(ref _PresetGeometry, value, nameof(PresetGeometry)); }

  private PresetGeometry? _PresetGeometry;
  /// <summary>
  /// Specifies the fill.
  /// </summary>
  public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

  private Fill? _Fill;
  /// <summary>
  /// Specifies the outline.
  /// </summary>
  public LineProperties? Outline { get => _Outline; set => UpdateField(ref _Outline, value, nameof(Outline)); }

  private LineProperties? _Outline;
  /// <summary>
  /// Specifies the effect list.
  /// </summary>
  public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

  private EffectList? _EffectList;
  /// <summary>
  /// Specifies the effect dag.
  /// </summary>
  public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }

  private EffectDag? _EffectDag;
  /// <summary>
  /// Specifies the scene3d type.
  /// </summary>
  public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }

  private Scene3DType? _Scene3DType;
  /// <summary>
  /// Specifies the shape3d type.
  /// </summary>
  public Shape3DType? Shape3DType { get => _Shape3DType; set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType)); }

  private Shape3DType? _Shape3DType;
  /// <summary>
  /// Specifies the shape properties extension list.
  /// </summary>
  public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get => _ShapePropertiesExtensionList; set => UpdateField(ref _ShapePropertiesExtensionList, value, nameof(ShapePropertiesExtensionList)); }

  private ShapePropertiesExtensionList? _ShapePropertiesExtensionList;
}