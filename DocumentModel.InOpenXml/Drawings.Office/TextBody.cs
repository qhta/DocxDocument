namespace DocumentModel.Drawings.Office;
/// <summary>
///   Represents a DrawingML text body in Office documents, providing configuration for body properties, list styles, and paragraph content.
///   Enables advanced text layout, formatting, and styling for shapes, text boxes, and graphical elements.
/// </summary>
[OpenXmlType(typeof(DXOD.TextBody))]
public partial class TextBody : ModelElement<DXOD.TextBody>
{
  /// <summary>
  ///   Properties that define the layout, wrapping, and formatting of the text body (e.g., margins, vertical alignment, columns).
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.TextBody.BodyProperties))]
  public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }
  private BodyProperties? _BodyProperties;
  /// <summary>
  ///   List style definitions for the text body, specifying bullet, numbering, and indentation formatting for paragraphs.
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.TextBody.ListStyle))]
  public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }
  private ListStyle? _ListStyle;
  /// <summary>
  ///   The paragraph content of the text body, containing text runs, fields, and inline formatting.
  /// </summary>
  public Paragraph? Paragraph { get => _Paragraph; set => UpdateField(ref _Paragraph, value, nameof(Paragraph)); }
  private Paragraph? _Paragraph;
}
