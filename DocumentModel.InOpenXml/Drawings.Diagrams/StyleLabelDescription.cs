namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Style Label Description.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleLabelDescription))]
public class StyleLabelDescription : ModelElement<DXDD.StyleLabelDescription>
{
 /// <summary>
 ///   Natural Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleLabelDescription.Language))]
 public string? Language { get; set; }

 /// <summary>
 ///   Description Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleLabelDescription.Val))]
 public string? Val { get; set; }
}

