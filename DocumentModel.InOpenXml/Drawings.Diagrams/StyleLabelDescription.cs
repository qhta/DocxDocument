namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Style Label Description.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleLabelDescription))]
/// <summary>
/// Represents the Style Label Description.
/// </summary>
public class StyleLabelDescription : ModelElement<DXDD.StyleLabelDescription>
{
 /// <summary>
 ///   Natural Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleLabelDescription.Language))]
 /// <summary>
 /// Language.
 /// </summary>
 public string? Language { get; set; }

 /// <summary>
 ///   Description Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleLabelDescription.Val))]
 /// <summary>
 /// Val.
 /// </summary>
 public string? Val { get; set; }
}


