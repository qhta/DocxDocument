namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Color Transform Category.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorTransformCategory))]
[XmlRoot("ColorTransformCategory", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class ColorTransformCategory : ModelElement<DXDD.ColorTransformCategory>
{
 /// <summary>
 ///   Category Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformCategory.Type))]
 public string? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private string? _Type;
 /// <summary>
 ///   Priority
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformCategory.Priority))]
 public UInt32? Priority { get => _Priority; set => UpdateField(ref _Priority, value, nameof(Priority)); }

 private UInt32? _Priority;
}