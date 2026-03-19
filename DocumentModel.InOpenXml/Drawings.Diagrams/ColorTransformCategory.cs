namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Color Transform Category.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorTransformCategory))]
public class ColorTransformCategory : ModelElement<DXDD.ColorTransformCategory>
{
 /// <summary>
 ///   Category Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformCategory.Type))]
 public string? Type { get; set; }

 /// <summary>
 ///   Priority
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformCategory.Priority))]
 public UInt32? Priority { get; set; }
}