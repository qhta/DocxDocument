namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents text formatting and layout properties for chart elements.
///   This class allows configuration of body properties, list styles, and paragraph formatting for text displayed in charts, such as titles, labels, or legends.
/// </summary>
[OpenXmlType(typeof(DXDC.TextProperties))]
[DataContract]
[XmlRoot("TextProperties", Namespace = "DocumentModel.Drawings.Charts")]
public partial class TextProperties : ModelElement<DXDC.TextProperties>
{
 /// <summary>
 ///   Properties that define the overall text body formatting, such as rotation, anchor, and wrapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.TextProperties.BodyProperties))]
 public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }
 private BodyProperties? _BodyProperties;

 /// <summary>
 ///   List style settings for text, including bullet and numbering options.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.TextProperties.ListStyle))]
 public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }
 private ListStyle? _ListStyle;

 /// <summary>
 ///   Paragraph formatting and content for the text, including alignment, indentation, and runs.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Paragraph))]
 public Paragraph? Paragraph { get => _Paragraph; set => UpdateField(ref _Paragraph, value, nameof(Paragraph)); }
 private Paragraph? _Paragraph;
}