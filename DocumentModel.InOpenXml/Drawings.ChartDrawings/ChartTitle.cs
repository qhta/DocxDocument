namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the title displayed for a chart with positioning and formatting options.
/// </summary>
/// <remarks>
///   This class defines the title element that appears at the
///   top or other designated position of a chart, providing a descriptive label for the entire visualization.
///   The chart title includes comprehensive positioning control (side position and alignment), overlay behavior
///   for space optimization, text content, visual styling through shape properties, text formatting properties,
///   and support for custom extensions. Chart titles help users quickly understand what the chart represents
///   and can be positioned flexibly around the chart area. The title can overlay the plot area to save space
///   or be positioned outside the plot area for clearer separation. Extensive customization options enable
///   the title to match the chart's overall design while maintaining readability and visual hierarchy.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.ChartTitle))]
public class ChartTitle: ModelElement<DXO16DCD.ChartTitle>
{
  /// <summary>
  /// Specifies the pos.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ChartTitle.Pos))]
  public SidePos? Pos { get => _Pos; set => UpdateField(ref _Pos, value, nameof(Pos)); }

  private SidePos? _Pos;

  /// <summary>
  /// Specifies the align.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ChartTitle.Align))]
  public PosAlign? Align { get => _Align; set => UpdateField(ref _Align, value, nameof(Align)); }

  private PosAlign? _Align;

  /// <summary>
  /// Specifies the overlay.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ChartTitle.Overlay))]
  public bool? Overlay { get => _Overlay; set => UpdateField(ref _Overlay, value, nameof(Overlay)); }

  private bool? _Overlay;

  /// <summary>
  /// Specifies the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ChartTitle.Text))]
  public Text? Text { get => _Text; set => UpdateField(ref _Text, value, nameof(Text)); }

  private Text? _Text;

  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ChartTitle.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties;
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  /// Specifies the tx pr text body.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ChartTitle.TxPrTextBody))]
  public TxPrTextBody? TxPrTextBody
  {
    get => _TxPrTextBody;
    set => UpdateField(ref _TxPrTextBody, value, nameof(TxPrTextBody));
  }

  private TxPrTextBody? _TxPrTextBody;

  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.ChartTitle.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}