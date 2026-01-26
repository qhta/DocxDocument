namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Shape Properties.
/// </summary>
[OpenXmlType(typeof(DXDP.ShapeProperties))]
public partial class ShapeProperties : ModelElement<DXDP.ShapeProperties>
{
 /// <summary>
 ///   Black and White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXDP.ShapeProperties.BlackWhiteMode))]
 /// <summary>
 ///   Black and White Mode
 /// </summary>
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

 private BlackWhiteMode? _BlackWhiteMode;
 /// <summary>
 ///   2D Transform for Individual Objects.
 /// </summary>
 [OpenXmlProperty(nameof(DXDP.ShapeProperties.Transform2D))]
 /// <summary>
 ///   2D Transform for Individual Objects.
 /// </summary>
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

 private Transform2D? _Transform2D;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public CustomGeometry? CustomGeometry { get => _CustomGeometry; set => UpdateField(ref _CustomGeometry, value, nameof(CustomGeometry)); }

 private CustomGeometry? _CustomGeometry;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public PresetGeometry? PresetGeometry { get => _PresetGeometry; set => UpdateField(ref _PresetGeometry, value, nameof(PresetGeometry)); }

 private PresetGeometry? _PresetGeometry;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public bool? NoFill { get => _NoFill; set => UpdateField(ref _NoFill, value, nameof(NoFill)); }

 private bool? _NoFill;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public SolidFill? SolidFill { get => _SolidFill; set => UpdateField(ref _SolidFill, value, nameof(SolidFill)); }

 private SolidFill? _SolidFill;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public GradientFill? GradientFill { get => _GradientFill; set => UpdateField(ref _GradientFill, value, nameof(GradientFill)); }

 private GradientFill? _GradientFill;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public Drawings.BlipFill? BlipFill { get => _BlipFill; set => UpdateField(ref _BlipFill, value, nameof(BlipFill)); }

 private Drawings.BlipFill? _BlipFill;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public PatternFill? PatternFill { get => _PatternFill; set => UpdateField(ref _PatternFill, value, nameof(PatternFill)); }

 private PatternFill? _PatternFill;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public bool? GroupFill { get => _GroupFill; set => UpdateField(ref _GroupFill, value, nameof(GroupFill)); }

 private bool? _GroupFill;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public LineProperties? Outline { get => _Outline; set => UpdateField(ref _Outline, value, nameof(Outline)); }

 private LineProperties? _Outline;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

 private EffectList? _EffectList;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }

 private EffectDag? _EffectDag;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }

 private Scene3DType? _Scene3DType;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public Shape3DType? Shape3DType { get => _Shape3DType; set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType)); }

 private Shape3DType? _Shape3DType;
 [OpenXmlElement(typeof(DXDP.ShapeProperties))]
 public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get => _ShapePropertiesExtensionList; set => UpdateField(ref _ShapePropertiesExtensionList, value, nameof(ShapePropertiesExtensionList)); }

 private ShapePropertiesExtensionList? _ShapePropertiesExtensionList;
}