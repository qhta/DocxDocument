namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Category.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleDisplayCategory))]
public class StyleDisplayCategory : ModelElement<DXDD.StyleDisplayCategory>
{
 /// <summary>
 ///   Category Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleDisplayCategory.Type))]
 public string? Type { get; set; }

 /// <summary>
 ///   Priority
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleDisplayCategory.Priority))]
 public UInt32? Priority { get; set; }
}