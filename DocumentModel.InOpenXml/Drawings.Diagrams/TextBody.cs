namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Text Body.
/// </summary>
[OpenXmlType(typeof(DXDD.TextBody))]
[DataContract]
[XmlRoot("TextBody", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class TextBody: ModelElement<DXDD.TextBody>
{
  /// <summary>
  ///   Body Properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.TextBody.BodyProperties))]
  public BodyProperties? BodyProperties
  {
    get => _BodyProperties ??= GetProperty<BodyProperties?>(GetUpdatableElement()?.BodyProperties);
    set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties));
  }

  private BodyProperties? _BodyProperties;

  /// <summary>
  ///   Text List Styles.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.TextBody.ListStyle))]
  public ListStyle? ListStyle
  {
    get => _ListStyle ??= GetProperty<ListStyle?>(GetUpdatableElement()?.ListStyle);
    set => UpdateField(ref _ListStyle, value, nameof(ListStyle));
  }

  private ListStyle? _ListStyle;

  /// <summary>
  /// Paragraph.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Paragraph))]
  public Paragraph? Paragraph
  {
    get => _Paragraph ??= GetElement<Paragraph, DXD.Paragraph>(GetUpdatableElement());
    set => UpdateField(ref _Paragraph, value, nameof(Paragraph));
  }

  private Paragraph? _Paragraph;
}