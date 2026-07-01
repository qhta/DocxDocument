namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Title.
/// </summary>
[OpenXmlType(typeof(DXDD.Title))]
[DataContract]
[XmlRoot("Title", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class Title : ModelElement<DXDD.Title>
{
 /// <summary>
 ///   Language
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Title.Language))]
 public string? Language { get => _Language; set => UpdateField(ref _Language, value, nameof(Language)); }
 private string? _Language;

 /// <summary>
 ///   Value
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.Title.Val))]
 public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }
 private string? _Val;
}