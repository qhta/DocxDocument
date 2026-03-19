namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Color Transform Category.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorTransformCategory))]
/// <summary>
/// Represents the Color Transform Category.
/// </summary>
public class ColorTransformCategory : ModelElement<DXDD.ColorTransformCategory>
{
 /// <summary>
 ///   Category Type
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformCategory.Type))]
 /// <summary>
 /// Type.
 /// </summary>
 public string? Type { get; set; }

 /// <summary>
 ///   Priority
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformCategory.Priority))]
 /// <summary>
 /// Priority.
 /// </summary>
 public UInt32? Priority { get; set; }
}

