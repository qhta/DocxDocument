namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the RichTextBody Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.RichTextBody))]
public class RichTextBody: ModelElement<DXO16DCD.RichTextBody>
{
  /// <summary>
  /// Specifies the body properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.RichTextBody.BodyProperties))]
  public BodyProperties? BodyProperties
  {
    get => _BodyProperties;
    set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties));
  }

  private BodyProperties? _BodyProperties;

  /// <summary>
  /// Specifies the list style.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.RichTextBody.ListStyle))]
  public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }

  private ListStyle? _ListStyle;
}