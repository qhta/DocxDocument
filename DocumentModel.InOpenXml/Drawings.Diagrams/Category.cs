namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Category.
/// </summary>
[OpenXmlType(typeof(DXDD.Category))]
public class Category : ModelElement<DXDD.Category>
{
 /// <summary>
 ///   Category Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Category.Type))]
 public string? Type { get; set; }

 /// <summary>
 ///   Priority
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Category.Priority))]
 public UInt32? Priority { get; set; }
}