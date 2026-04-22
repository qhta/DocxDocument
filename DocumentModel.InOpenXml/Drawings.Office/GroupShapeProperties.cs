namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the GroupShapeProperties Class.
/// </summary>
[OpenXmlType(typeof(DXOD.GroupShapeProperties))]
[XmlRoot("GroupShapeProperties", Namespace = "DocumentModel.Drawings.Office")]
public partial class GroupShapeProperties : ModelElement<DXOD.GroupShapeProperties>
{
 /// <summary>
 ///   Specifies the black and white mode for the group shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.GroupShapeProperties.BlackWhiteMode))]
 public BlackWhiteMode? BlackWhiteMode { get => _BlackWhiteMode; set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode)); }
 private BlackWhiteMode? _BlackWhiteMode;

 /// <summary>
 ///   Represents the 2D transformation for grouped objects.
 /// </summary>
 [OpenXmlProperty(nameof(DXOD.GroupShapeProperties.TransformGroup))]
 public TransformGroup? TransformGroup { get => _TransformGroup; set => UpdateField(ref _TransformGroup, value, nameof(TransformGroup)); }
 private TransformGroup? _TransformGroup;

 /// <summary>
 ///   Represents the fill properties for the group shape.
 /// </summary>
 public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }
 private Fill? _Fill;

 /// <summary>
 ///   Represents the list of effects applied to the group shape.
 /// </summary>
 public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }
 private EffectList? _EffectList;

 /// <summary>
 ///   Represents the effect DAG (Directed Acyclic Graph) for the group shape.
 /// </summary>
 public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }
 private EffectDag? _EffectDag;

 /// <summary>
 ///   Represents the 3D scene properties for the group shape.
 /// </summary>
 public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }
 private Scene3DType? _Scene3DType;

 /// <summary>
 ///   Represents the extension list for the group shape.
 /// </summary>
 public IExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private IExtensionList? _ExtensionList;
}