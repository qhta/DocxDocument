namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Text Body.
/// </summary>
[OpenXmlType(typeof(DXDD.TextBody))]
[XmlRoot("TextBody", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class TextBody : ModelElement<DXDD.TextBody>
{
 /// <summary>
 ///   Body Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.TextBody.BodyProperties))]
 public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }

 private BodyProperties? _BodyProperties;
 /// <summary>
 ///   Text List Styles.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.TextBody.ListStyle))]
 public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }

 private ListStyle? _ListStyle;
 /// <summary>
 /// Paragraph.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Paragraph))]
 public Paragraph? Paragraph { get => _Paragraph; set => UpdateField(ref _Paragraph, value, nameof(Paragraph)); }

 private Paragraph? _Paragraph;
}