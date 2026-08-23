namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes the text body of a shape in chart drawings, including body formatting, list styles, and paragraph content.
/// </summary>
/// <remarks>
/// <para>The following table lists the possible child types:</para>
/// <list type="bullet">
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.BodyProperties"/> <c>&lt;a:bodyPr&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.ListStyle"/> <c>&lt;a:lstStyle&gt;</c></description></item>
///   <item><description><see cref="T:DocumentFormat.OpenXml.Drawing.Paragraph"/> <c>&lt;a:p&gt;</c></description></item>
/// </list>
/// </remarks>
[OpenXmlType(typeof(DXDCD.TextBody))]
[DataContract]
[XmlRoot("TextBody", Namespace = "DocumentModel.Drawings.ChartDrawing")]
public partial class TextBody: ModelElement<DXDCD.TextBody>
{
  /// <summary>
  /// Formatting properties for the text body, such as insets, wrapping, and rotation.
  /// </summary>
  [OpenXmlElement(typeof(DXD.BodyProperties))]
  public BodyProperties? BodyProperties
  {
    get => _BodyProperties ??= GetElement<BodyProperties, DXD.BodyProperties>(GetUpdatableElement());
    set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties));
  }

  private BodyProperties? _BodyProperties;

  /// <summary>
  /// Styles applied to bulleted or numbered lists within the text body.
  /// </summary>
  [OpenXmlElement(typeof(DXD.ListStyle))]
  public ListStyle? ListStyle
  {
    get => _ListStyle ??= GetElement<ListStyle, DXD.ListStyle>(GetUpdatableElement());
    set => UpdateField(ref _ListStyle, value, nameof(ListStyle));
  }

  private ListStyle? _ListStyle;

  /// <summary>
  /// Paragraph content and formatting within the text body.
  /// </summary>
  [OpenXmlElement(typeof(DXD.Paragraph))]
  public Paragraph? Paragraph
  {
    get => _Paragraph ??= GetElement<Paragraph, DXD.Paragraph>(GetUpdatableElement());
    set => UpdateField(ref _Paragraph, value, nameof(Paragraph));
  }

  private Paragraph? _Paragraph;
}