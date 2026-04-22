namespace DocumentModel.Drawings;
/// <summary>
/// Represents a style that defines a set of effects and 3D properties for a drawing element.
/// </summary>
[OpenXmlType(typeof(DXD.EffectStyle))]
[XmlRoot("EffectStyle", Namespace = "DocumentModel.Drawings")]
public partial class EffectStyle : ModelElement<DXD.EffectStyle>, IExtendableElement
{
 /// <summary>
 /// List of effects applied to the drawing element.
 /// </summary>
 public EffectList? EffectList { get => _EffectList; set => UpdateField(ref _EffectList, value, nameof(EffectList)); }
 private EffectList? _EffectList;

 /// <summary>
 /// Effect directed acyclic graph, which defines the structure and relationships of effects.
 /// </summary>
 public EffectDag? EffectDag { get => _EffectDag; set => UpdateField(ref _EffectDag, value, nameof(EffectDag)); }
 private EffectDag? _EffectDag;

 /// <summary>
 /// Gets or sets the 3D scene type, specifying the 3D environment for the drawing element.
 /// </summary>
 public Scene3DType? Scene3DType { get => _Scene3DType; set => UpdateField(ref _Scene3DType, value, nameof(Scene3DType)); }
 private Scene3DType? _Scene3DType;

 /// <summary>
 /// Gets or sets the 3D shape type, specifying the 3D geometry for the drawing element.
 /// </summary>
 public Shape3DType? Shape3DType { get => _Shape3DType; set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType)); }
 private Shape3DType? _Shape3DType;

 /// <summary>
 /// List of extension elements.
 /// </summary>
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}