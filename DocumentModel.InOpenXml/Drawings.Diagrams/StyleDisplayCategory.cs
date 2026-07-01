namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Category.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleDisplayCategory))]
[DataContract]
[XmlRoot("StyleDisplayCategory", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class StyleDisplayCategory : ModelElement<DXDD.StyleDisplayCategory>
{
 /// <summary>
 ///   Category Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleDisplayCategory.Type))]
 public string? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
 private string? _Type;

 /// <summary>
 ///   Priority
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleDisplayCategory.Priority))]
 public UInt32? Priority { get => _Priority; set => UpdateField(ref _Priority, value, nameof(Priority)); }
 private UInt32? _Priority;
}