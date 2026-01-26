namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the ShapeProperties Class.
/// </summary>
[OpenXmlType(typeof(DXOD.ShapeProperties))]
public partial class ShapeProperties : ModelElement<DXOD.ShapeProperties>
{
 /// <summary>
 ///   Black and White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.ShapeProperties.BlackWhiteMode))]
 [OpenXmlElement(typeof(DXOD.ShapeProperties))]
 public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

 private BlackWhiteMode? _BlackWhiteMode;
 /// <summary>
 ///   2D Transform for Individual Objects.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.ShapeProperties.Transform2D))]
 [OpenXmlElement(typeof(DXOD.ShapeProperties))]
 public Drawings.Transform2D? Transform2D { get => _Transform2D; set => UpdateField(ref _Transform2D, value, nameof(Transform2D)); }

 private Drawings.Transform2D? _Transform2D;
 [OpenXmlElement(typeof(DXOD.ShapeProperties))]
 public CustomGeometry? CustomGeometry { get => _CustomGeometry; set => UpdateField(ref _CustomGeometry, value, nameof(CustomGeometry)); }

 private CustomGeometry? _CustomGeometry;
 [OpenXmlElement(typeof(DXOD.ShapeProperties))]
 public PresetGeometry? PresetGeometry { get => _PresetGeometry; set => UpdateField(ref _PresetGeometry, value, nameof(PresetGeometry)); }

 private PresetGeometry? _PresetGeometry;
 [OpenXmlElement(typeof(DXOD.ShapeProperties))]
 public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

 private Fill? _Fill;
 [OpenXmlElement(typeof(DXOD.ShapeProperties))]
 public LineProperties? Outline { get => _Outline; set => UpdateField(ref _Outline, value, nameof(Outline)); }

 private LineProperties? _Outline;
 [OpenXmlElement(typeof(DXOD.ShapeProperties))]
 public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

 private EffectList? _EffectList;
 [OpenXmlElement(typeof(DXOD.ShapeProperties))]
 public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }

 private EffectDag? _EffectDag;
 [OpenXmlElement(typeof(DXOD.ShapeProperties))]
 public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }

 private Scene3DType? _Scene3DType;
 [OpenXmlElement(typeof(DXOD.ShapeProperties))]
 public Shape3DType? Shape3DType { get => _Shape3DType; set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType)); }

 private Shape3DType? _Shape3DType;
 [OpenXmlElement(typeof(DXOD.ShapeProperties))]
 public ShapePropertiesExtensionList? ShapePropertiesExtensionList { get => _ShapePropertiesExtensionList; set => UpdateField(ref _ShapePropertiesExtensionList, value, nameof(ShapePropertiesExtensionList)); }

 private ShapePropertiesExtensionList? _ShapePropertiesExtensionList;
}