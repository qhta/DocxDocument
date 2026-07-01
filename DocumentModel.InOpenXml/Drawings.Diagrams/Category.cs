namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Category.
/// </summary>
[OpenXmlType(typeof(DXDD.Category))]
[DataContract]
[XmlRoot("Category", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class Category : ModelElement<DXDD.Category>
{
 /// <summary>
 ///   Category Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Category.Type))]
 public string? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
 private string? _Type;

 /// <summary>
 ///   Priority
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Category.Priority))]
 public UInt32? Priority { get => _Priority; set => UpdateField(ref _Priority, value, nameof(Priority)); }
 private UInt32? _Priority;
}