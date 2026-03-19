namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Description.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorTransformDescription))]
public class ColorTransformDescription : ModelElement<DXDD.ColorTransformDescription>
{
 /// <summary>
 ///   Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformDescription.Language))]
 public string? Language { get; set; }

 /// <summary>
 ///   Description Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.ColorTransformDescription.Val))]
 public string? Val { get; set; }
}