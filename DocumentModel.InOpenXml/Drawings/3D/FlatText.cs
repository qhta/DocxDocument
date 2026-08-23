namespace DocumentModel.Drawings;
/// <summary>
///   Indicates that text is not rendered in 3D scene.
/// </summary>
[OpenXmlType(typeof(DXD.FlatText))]
[DataContract]
[XmlRoot("FlatText", Namespace = "DocumentModel.Drawings")]
public partial class FlatText : ModelElement<DXD.FlatText>
{
 /// <summary>
 ///   Z coordinate for positioning in 3D space.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FlatText.Z))]
 public Int64? Z { get => _Z ??= GetProperty<Int64?>(GetUpdatableElement()?.Z); set => UpdateField(ref _Z, value, nameof(Z)); }
 private Int64? _Z;
}