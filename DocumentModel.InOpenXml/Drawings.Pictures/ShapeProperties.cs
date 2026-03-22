namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Represents the set of shape properties for a DrawingML picture, including fill, outline, effects, geometry, and 3D formatting.
///   Enables advanced configuration and rendering of shapes and images in Office documents.
/// </summary>
[OpenXmlType(typeof(DXDP.ShapeProperties))]
public partial class ShapeProperties : ModelElement<DXDP.ShapeProperties>
{
  /// <summary>
  ///   Black and white rendering mode for the shape, controlling how the shape appears in monochrome or grayscale output.
  /// </summary>
  [OpenXmlProperty(nameof(DXDP.ShapeProperties.BlackWhiteMode))]
  public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }
  private BlackWhiteMode? _BlackWhiteMode;
  /// <summary>
  ///   2D transformation for the shape, specifying scaling, rotation, and translation for layout and positioning.
  /// </summary>
  [OpenXmlProperty(nameof(DXDP.ShapeProperties.Transform2D))]
  public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }
  private Transform2D? _Transform2D;
  /// <summary>
  ///   Custom geometry definition for the shape, allowing for user-defined shapes and paths.
  /// </summary>
  public CustomGeometry? CustomGeometry { get => _CustomGeometry; set => UpdateField(ref _CustomGeometry, value, nameof(CustomGeometry)); }
  private CustomGeometry? _CustomGeometry;
  /// <summary>
  ///   Preset geometry definition for the shape, selecting from predefined shapes and line types.
  /// </summary>
  public PresetGeometry? PresetGeometry { get => _PresetGeometry; set => UpdateField(ref _PresetGeometry, value, nameof(PresetGeometry)); }
  private PresetGeometry? _PresetGeometry;
  /// <summary>
  ///   Indicates that the shape has no fill applied.
  /// </summary>
  public bool? NoFill { get => _NoFill; set => UpdateField(ref _NoFill, value, nameof(NoFill)); }
  private bool? _NoFill;
  /// <summary>
  ///   Solid fill formatting for the shape, specifying a single color fill.
  /// </summary>
  public SolidFill? SolidFill { get => _SolidFill; set => UpdateField(ref _SolidFill, value, nameof(SolidFill)); }
  private SolidFill? _SolidFill;
  /// <summary>
  ///   Gradient fill formatting for the shape, specifying a color gradient fill.
  /// </summary>
  public GradientFill? GradientFill { get => _GradientFill; set => UpdateField(ref _GradientFill, value, nameof(GradientFill)); }
  private GradientFill? _GradientFill;
  /// <summary>
  ///   Blip fill formatting for the shape, specifying an image or texture fill.
  /// </summary>
  public Drawings.BlipFill? BlipFill { get => _BlipFill; set => UpdateField(ref _BlipFill, value, nameof(BlipFill)); }
  private Drawings.BlipFill? _BlipFill;
  /// <summary>
  ///   Pattern fill formatting for the shape, specifying a repeating pattern fill.
  /// </summary>
  public PatternFill? PatternFill { get => _PatternFill; set => UpdateField(ref _PatternFill, value, nameof(PatternFill)); }
  private PatternFill? _PatternFill;
  /// <summary>
  ///   Indicates that the shape uses the group fill from its parent group shape.
  /// </summary>
  public bool? GroupFill { get => _GroupFill; set => UpdateField(ref _GroupFill, value, nameof(GroupFill)); }
  private bool? _GroupFill;
  /// <summary>
  ///   Outline (stroke) formatting for the shape, specifying line color, width, and style.
  /// </summary>
  public LineProperties? Outline { get => _Outline; set => UpdateField(ref _Outline, value, nameof(Outline)); }
  private LineProperties? _Outline;
  /// <summary>
  ///   List of visual effects applied to the shape, such as shadows, glows, and reflections.
  /// </summary>
  public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }
  private EffectList? _EffectList;
  /// <summary>
  ///   Effect DAG (Directed Acyclic Graph) for advanced effect sequencing and layering.
  /// </summary>
  public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }
  private EffectDag? _EffectDag;
  /// <summary>
  ///   3D scene formatting for the shape, specifying camera, lighting, and perspective settings.
  /// </summary>
  public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }
  private Scene3DType? _Scene3DType;
  /// <summary>
  ///   3D shape formatting for the shape, specifying extrusion, bevel, and contour settings.
  /// </summary>
  public Shape3DType? Shape3DType { get => _Shape3DType; set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType)); }
  private Shape3DType? _Shape3DType;
  /// <summary>
  ///   List of extension elements for the shape properties, supporting extensibility and application-specific data.
  /// </summary>
  public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get => _ShapePropertiesExtensionList; set => UpdateField(ref _ShapePropertiesExtensionList, value, nameof(ShapePropertiesExtensionList)); }
  private ShapePropertiesExtensionList? _ShapePropertiesExtensionList;
}
