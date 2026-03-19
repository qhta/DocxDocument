namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Category.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleDisplayCategory))]
/// <summary>
/// Represents the Style Display Category.
/// </summary>
public class StyleDisplayCategory : ModelElement<DXDD.StyleDisplayCategory>
{
 /// <summary>
 ///   Category Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleDisplayCategory.Type))]
 /// <summary>
 /// Type.
 /// </summary>
 public string? Type { get; set; }

 /// <summary>
 ///   Priority
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleDisplayCategory.Priority))]
 /// <summary>
 /// Priority.
 /// </summary>
 public UInt32? Priority { get; set; }
}

