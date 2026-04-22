namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Style Label Description.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleLabelDescription))]
[XmlRoot("StyleLabelDescription", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class StyleLabelDescription : ModelElement<DXDD.StyleLabelDescription>
{
 /// <summary>
 ///   Natural Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleLabelDescription.Language))]
 public string? Language { get => _Language; set => UpdateField(ref _Language, value, nameof(Language)); }
 private string? _Language;

 /// <summary>
 ///   Description Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.StyleLabelDescription.Val))]
 public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }
 private string? _Val;
}