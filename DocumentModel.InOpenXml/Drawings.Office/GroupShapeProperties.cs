namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the GroupShapeProperties Class.
/// </summary>
[OpenXmlType(typeof(DXOD.GroupShapeProperties))]
public partial class GroupShapeProperties : ModelElement<DXOD.GroupShapeProperties>
{
 /// <summary>
 ///   Black and White Mode
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.GroupShapeProperties.BlackWhiteMode))]
 [OpenXmlElement(typeof(DXOD.GroupShapeProperties))]
 public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }

 private BlackWhiteMode? _BlackWhiteMode;
 /// <summary>
 ///   2D Transform for Grouped Objects.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.GroupShapeProperties.TransformGroup))]
 [OpenXmlElement(typeof(DXOD.GroupShapeProperties))]
 public TransformGroup? TransformGroup { get => _TransformGroup; set => UpdateField(ref _TransformGroup, value, nameof(TransformGroup)); }

 private TransformGroup? _TransformGroup;
 [OpenXmlElement(typeof(DXOD.GroupShapeProperties))]
 public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

 private Fill? _Fill;
 [OpenXmlElement(typeof(DXOD.GroupShapeProperties))]
 public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }

 private EffectList? _EffectList;
 [OpenXmlElement(typeof(DXOD.GroupShapeProperties))]
 public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }

 private EffectDag? _EffectDag;
 [OpenXmlElement(typeof(DXOD.GroupShapeProperties))]
 public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }

 private Scene3DType? _Scene3DType;
 [OpenXmlElement(typeof(DXOD.GroupShapeProperties))]
 public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private IExtensionList? _ExtensionList;
}