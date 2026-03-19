namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Description.
/// </summary>
[OpenXmlType(typeof(DXDD.Description))]
public class Description : ModelElement<DXDD.Description>
{
 /// <summary>
 ///   Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Description.Language))]
 public string? Language { get; set; }

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Description.Val))]
 public string? Val { get; set; }
}