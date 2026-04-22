namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the TextBodyType Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.TextBodyType))]
[XmlRoot("TextBodyType", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class TextBodyType : ModelElement<DXO16DCD.TextBodyType>
{
 /// <summary>
 /// Specifies the body properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.TextBodyType.BodyProperties))]
 public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }
 private BodyProperties? _BodyProperties;

 /// <summary>
 /// Specifies the list style.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.TextBodyType.ListStyle))]
 public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }
 private ListStyle? _ListStyle;
}