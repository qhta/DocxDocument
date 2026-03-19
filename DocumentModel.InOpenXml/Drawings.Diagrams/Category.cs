namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Category.
/// </summary>
[OpenXmlType(typeof(DXDD.Category))]
/// <summary>
/// Represents the Category.
/// </summary>
public class Category : ModelElement<DXDD.Category>
{
 /// <summary>
 ///   Category Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Category.Type))]
 /// <summary>
 /// Type.
 /// </summary>
 public string? Type { get; set; }

 /// <summary>
 ///   Priority
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Category.Priority))]
 /// <summary>
 /// Priority.
 /// </summary>
 public UInt32? Priority { get; set; }
}

