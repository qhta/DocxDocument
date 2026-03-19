namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Title.
/// </summary>
[OpenXmlType(typeof(DXDD.Title))]
public class Title : ModelElement<DXDD.Title>
{
 /// <summary>
 ///   Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Title.Language))]
 public string? Language { get; set; }

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Title.Val))]
 public string? Val { get; set; }
}