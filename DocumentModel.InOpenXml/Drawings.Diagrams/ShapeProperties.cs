namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Shape Properties.
/// </summary>
[OpenXmlType(typeof(DXDD.ShapeProperties))]
[XmlRoot("ShapeProperties", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class ShapeProperties : ModelElement<DXDD.ShapeProperties>
{
 /// <summary>
 ///   Black and White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ShapeProperties.BlackWhiteMode))]
 public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

 private BlackWhiteMode? _BlackWhiteMode;
 /// <summary>
 ///   2D Transform for Individual Objects.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ShapeProperties.Transform2D))]
 public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

 private Transform2D? _Transform2D;
 /// <summary>
 /// Custom Geometry.
 /// </summary>
 [OpenXmlElement(typeof(DXD.CustomGeometry))]
 public CustomGeometry? CustomGeometry { get => _CustomGeometry; set => UpdateField(ref _CustomGeometry, value, nameof(CustomGeometry)); }

 private CustomGeometry? _CustomGeometry;
 /// <summary>
 /// Preset Geometry.
 /// </summary>
 [OpenXmlElement(typeof(DXD.PresetGeometry))]
 public PresetGeometry? PresetGeometry { get => _PresetGeometry; set => UpdateField(ref _PresetGeometry, value, nameof(PresetGeometry)); }

 private PresetGeometry? _PresetGeometry;
 /// <summary>
 /// Fill.
 /// </summary>
 [OpenXmlElement(typeof(DXD.NoFill))]
 public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

 private Fill? _Fill;
 /// <summary>
 /// Outline.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Outline))]
 public LineProperties? Outline { get => _Outline; set => UpdateField(ref _Outline, value, nameof(Outline)); }

 private LineProperties? _Outline;
 /// <summary>
 /// Effect List.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EffectList))]
 public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

 private EffectList? _EffectList;
 /// <summary>
 /// Effect Dag.
 /// </summary>
 [OpenXmlElement(typeof(DXD.EffectDag))]
 public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }

 private EffectDag? _EffectDag;
 /// <summary>
 /// Scene3 DType.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Scene3DType))]
 public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }

 private Scene3DType? _Scene3DType;
 /// <summary>
 /// Shape3 DType.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Shape3DType))]
 public Shape3DType? Shape3DType { get => _Shape3DType; set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType)); }

 private Shape3DType? _Shape3DType;
 /// <summary>
 /// Shape Properties Extension List.
 /// </summary>
 [OpenXmlElement(typeof(DXD.ShapePropertiesExtensionList))]
 public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get => _ShapePropertiesExtensionList; set => UpdateField(ref _ShapePropertiesExtensionList, value, nameof(ShapePropertiesExtensionList)); }

 private ShapePropertiesExtensionList? _ShapePropertiesExtensionList;
}