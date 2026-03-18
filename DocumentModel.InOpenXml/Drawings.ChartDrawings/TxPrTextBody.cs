namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the TxPrTextBody Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.TxPrTextBody))]
public class TxPrTextBody: ModelElement<DXO16DCD.TxPrTextBody>
{
  /// <summary>
  /// Specifies the body properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.TxPrTextBody.BodyProperties))]
  public BodyProperties? BodyProperties
  {
    get => _BodyProperties;
    set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties));
  }

  private BodyProperties? _BodyProperties;

  /// <summary>
  /// Specifies the list style.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.TxPrTextBody.ListStyle))]
  public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }

  private ListStyle? _ListStyle;

  /// <summary>
  /// Specifies the paragraph.
  /// </summary>
  public Paragraph? Paragraph { get => _Paragraph; set => UpdateField(ref _Paragraph, value, nameof(Paragraph)); }

  private Paragraph? _Paragraph;
}