namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Title.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleDefinitionTitle))]
/// <summary>
/// Represents the Style Definition Title.
/// </summary>
public class StyleDefinitionTitle : ModelElement<DXDD.StyleDefinitionTitle>
{
 /// <summary>
 ///   Natural Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleDefinitionTitle.Language))]
 /// <summary>
 /// Language.
 /// </summary>
 public string? Language { get; set; }

 /// <summary>
 ///   Description Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleDefinitionTitle.Val))]
 /// <summary>
 /// Val.
 /// </summary>
 public string? Val { get; set; }
}

