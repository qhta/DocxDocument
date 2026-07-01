namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents rich text content in a chart.
///   This class allows defining formatting properties, list styles, and paragraph content for text elements.
/// </summary>
[OpenXmlType(typeof(DXDC.RichText))]
[DataContract]
[XmlRoot("RichText", Namespace = "DocumentModel.Drawings.Charts")]
public partial class RichText : ModelElement<DXDC.RichText>
{
 /// <summary>
 ///   Body formatting properties for the rich text.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.RichText.BodyProperties))]
 public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }
 private BodyProperties? _BodyProperties;

 /// <summary>
 ///   List style definitions for the rich text.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.RichText.ListStyle))]
 public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }
 private ListStyle? _ListStyle;

 /// <summary>
 ///   Paragraph content within the rich text.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Paragraph))]
 public Paragraph? Paragraph { get => _Paragraph; set => UpdateField(ref _Paragraph, value, nameof(Paragraph)); }
 private Paragraph? _Paragraph;
}