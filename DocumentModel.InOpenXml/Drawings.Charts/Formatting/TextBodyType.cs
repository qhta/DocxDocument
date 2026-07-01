namespace DocumentModel.Drawings.Charts;
/// <summary>
/// Represents the text body structure containing body properties and list styles for chart elements.
/// </summary>
[OpenXmlType(typeof(DXDC.TextBodyType))]
[DataContract]
[XmlRoot("TextBodyType", Namespace = "DocumentModel.Drawings.Charts")]
public partial class TextBodyType : ModelElement<DXDC.TextBodyType>
{
 /// <summary>
 /// Formatting properties for the body of the text, such as insets and text wrapping.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.TextBodyType.BodyProperties))]
 public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }
 private BodyProperties? _BodyProperties;

 /// <summary>
 /// Styles applied to bulleted or numbered lists within the text body.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.TextBodyType.ListStyle))]
 public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }
 private ListStyle? _ListStyle;
}