namespace DocumentModel.Drawings.Office;

/// <summary>
///   Represents the set of shape properties for a DrawingML shape in Office documents, including fill, outline, effects, geometry, and 3D formatting.
///   Enables advanced configuration and rendering of shapes and graphical elements in Office drawings.
/// </summary>
[OpenXmlType(typeof(DXOD.ShapeProperties))]
[DataContract]
[XmlRoot("ShapeProperties", Namespace = "DocumentModel.Drawings.Office")]
public partial class ShapeProperties: ModelElement<DXOD.ShapeProperties>
{
  /// <summary>
  ///   Black and white rendering mode for the shape, controlling how the shape appears in monochrome or grayscale output.
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.ShapeProperties.BlackWhiteMode))]
  public BlackWhiteMode? BlackWhiteMode
  {
    get => _BlackWhiteMode ??= GetProperty<BlackWhiteMode?>(GetUpdatableElement()?.BlackWhiteMode);
    set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode));
  }

  private BlackWhiteMode? _BlackWhiteMode;

  /// <summary>
  ///   2D transformation for the shape, specifying scaling, rotation, and translation for layout and positioning.
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.ShapeProperties.Transform2D))]
  public Drawings.Transform2D? Transform2D
  {
    get => _Transform2D ??= GetProperty<Drawings.Transform2D?>(GetUpdatableElement()?.Transform2D);
    set => UpdateField(ref _Transform2D, value, nameof(Transform2D));
  }

  private Drawings.Transform2D? _Transform2D;

  /// <summary>
  ///   Custom geometry definition for the shape, allowing for user-defined shapes and paths.
  /// </summary>
  public CustomGeometry? CustomGeometry
  {
    get => _CustomGeometry;
    set => UpdateField(ref _CustomGeometry, value, nameof(CustomGeometry));
  }

  private CustomGeometry? _CustomGeometry;

  /// <summary>
  ///   Preset geometry definition for the shape, selecting from predefined shapes and line types.
  /// </summary>
  public PresetGeometry? PresetGeometry
  {
    get => _PresetGeometry;
    set => UpdateField(ref _PresetGeometry, value, nameof(PresetGeometry));
  }

  private PresetGeometry? _PresetGeometry;

  /// <summary>
  ///   Fill formatting for the shape, specifying solid, gradient, pattern, or image fill.
  /// </summary>
  public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

  private Fill? _Fill;

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
  public Scene3DType? Scene3DType
  {
    get => _Scene3DType;
    set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType));
  }

  private Scene3DType? _Scene3DType;

  /// <summary>
  ///   3D shape formatting for the shape, specifying extrusion, bevel, and contour settings.
  /// </summary>
  public Shape3DType? Shape3DType
  {
    get => _Shape3DType;
    set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType));
  }

  private Shape3DType? _Shape3DType;

  /// <summary>
  ///   List of extension elements for the shape properties, supporting extensibility and application-specific data.
  /// </summary>
  public ShapePropertiesExtensionList? ShapePropertiesExtensionList
  {
    get => _ShapePropertiesExtensionList;
    set => UpdateField(ref _ShapePropertiesExtensionList, value, nameof(ShapePropertiesExtensionList));
  }

  private ShapePropertiesExtensionList? _ShapePropertiesExtensionList;
}