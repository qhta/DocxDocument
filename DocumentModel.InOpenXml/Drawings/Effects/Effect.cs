namespace DocumentModel.Drawings;
/// <summary>
///   Represents a reference to a visual effect that can be applied to drawing objects.
/// </summary>
[OpenXmlType(typeof(DXD.Effect))]
[XmlRoot("Effect", Namespace = "DocumentModel.Drawings")]
public partial class Effect : ModelElement<DXD.Effect>
{
 /// <summary>
 ///   Reference identifier that links to a specific effect definition.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Effect.Reference))]
 public string? Reference { get => _Reference; set => UpdateField(ref _Reference, value, nameof(Reference)); }
 private string? _Reference;
}