namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Text Properties.
/// </summary>
[OpenXmlType(typeof(DXDD.TextProperties))]
[XmlRoot("TextProperties", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class TextProperties : ModelElement<DXDD.TextProperties>
{
 /// <summary>
 ///   Apply 3D shape properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.TextProperties.Shape3DType))]
 public Shape3DType? Shape3DType { get => _Shape3DType; set => UpdateField(ref _Shape3DType, value, nameof(Shape3DType)); }
 private Shape3DType? _Shape3DType;

 /// <summary>
 ///   No text in 3D scene.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.TextProperties.FlatText))]
 public FlatText? FlatText { get => _FlatText; set => UpdateField(ref _FlatText, value, nameof(FlatText)); }
 private FlatText? _FlatText;
}