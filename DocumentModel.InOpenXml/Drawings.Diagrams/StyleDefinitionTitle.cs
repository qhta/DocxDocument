namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Title.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleDefinitionTitle))]
public class StyleDefinitionTitle : ModelElement<DXDD.StyleDefinitionTitle>
{
 /// <summary>
 ///   Natural Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleDefinitionTitle.Language))]
 public string? Language { get; set; }

 /// <summary>
 ///   Description Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleDefinitionTitle.Val))]
 public string? Val { get; set; }
}