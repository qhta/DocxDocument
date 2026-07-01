namespace DocumentModel.Drawings;
/// <summary>
///   Represents a shape guide, defining a named formula used for shape geometry calculations.
/// </summary>
[OpenXmlType(typeof(DXD.ShapeGuide))]
[DataContract]
[XmlRoot("ShapeGuide", Namespace = "DocumentModel.Drawings")]
public partial class ShapeGuide : ModelElement<DXD.ShapeGuide>
{
 /// <summary>
 ///   Name of the shape guide.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeGuide.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;

 /// <summary>
 ///   Formula used by the shape guide for geometry calculations.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.ShapeGuide.Formula))]
 public string? Formula { get => _Formula; set => UpdateField(ref _Formula, value, nameof(Formula)); }
 private string? _Formula;
}