namespace DocumentModel.Drawings;
/// <summary>
///   Represents visual properties for a shape, including geometry, fill, outline, effects, 2D and 3D transforms, and extension lists.
/// </summary>
[OpenXmlType(typeof(DXD.ShapeProperties))]
public partial class ShapeProperties : ModelElement<DXD.ShapeProperties>
{
 /// <summary>
 ///   Black and white rendering mode for the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeProperties.BlackWhiteMode))]
 /// <summary>
 ///   Black and white rendering mode for the shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapeProperties))]
 public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

 private BlackWhiteMode? _BlackWhiteMode;
 /// <summary>
 ///   2D transformation applied to the shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeProperties.Transform2D))]
 /// <summary>
 ///   2D transformation applied to the shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapeProperties))]
 public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

 private Transform2D? _Transform2D;
 /// <summary>
 ///   Custom geometry definition for the shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapeProperties))]
 public CustomGeometry? CustomGeometry { get => _CustomGeometry; set => UpdateField(ref _CustomGeometry, value, nameof(CustomGeometry)); }

 private CustomGeometry? _CustomGeometry;
 /// <summary>
 ///   Preset geometry definition for the shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapeProperties))]
 public PresetGeometry? PresetGeometry { get => _PresetGeometry; set => UpdateField(ref _PresetGeometry, value, nameof(PresetGeometry)); }

 private PresetGeometry? _PresetGeometry;
 /// <summary>
 ///   Fill formatting for the shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapeProperties))]
 public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

 private Fill? _Fill;
 /// <summary>
 ///   Outline formatting for the shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapeProperties))]
 public LineProperties? Outline { get => _Outline; set => UpdateField(ref _Outline, value, nameof(Outline)); }

 private LineProperties? _Outline;
 /// <summary>
 ///   List of effects applied to the shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapeProperties))]
 public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

 private EffectList? _EffectList;
 /// <summary>
 ///   Effect DAG (Directed Acyclic Graph) for advanced effect composition.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapeProperties))]
 public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }

 private EffectDag? _EffectDag;
 /// <summary>
 ///   3D scene properties for the shape.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapeProperties))]
 public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }

 private Scene3DType? _Scene3DType;
 /// <summary>
 ///   3D shape properties.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapeProperties))]
 public Shape3DType? Shape3DType { get => _Shape3DType; set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType)); }

 private Shape3DType? _Shape3DType;
 /// <summary>
 ///   Extension list for additional shape properties.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapeProperties))]
 public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get => _ShapePropertiesExtensionList; set => UpdateField(ref _ShapePropertiesExtensionList, value, nameof(ShapePropertiesExtensionList)); }

 private ShapePropertiesExtensionList? _ShapePropertiesExtensionList;
}