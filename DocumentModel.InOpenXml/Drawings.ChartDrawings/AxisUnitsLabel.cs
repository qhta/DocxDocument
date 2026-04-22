namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents the label displayed for axis units in a chart.
/// </summary>
/// <remarks>
///   This class defines the label element that describes
///   the units or scale applied to a chart axis. The axis units label provides textual context for the
///   magnitude or measurement type of axis values (e.g., "in millions", "Ä‚â€žÄąÄ…Ă„Ä…Ă„ËťÄ‚â€ąÄąÄ„Celsius", "USD", "percentage").
///   The label includes text content, visual styling properties through shape properties, text formatting
///   properties, and support for custom extensions. This label helps users interpret axis values correctly
///   by clarifying the scale factor or measurement unit, particularly when axis values are displayed in
///   abbreviated or scaled format. The label can be extensively customized in terms of appearance,
///   positioning, and text formatting to match the chart's overall design.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.AxisUnitsLabel))]
[XmlRoot("AxisUnitsLabel", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class AxisUnitsLabel : ModelElement<DXO16DCD.AxisUnitsLabel>
{
  /// <summary>
  /// Specifies the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.AxisUnitsLabel.Text))]
  public Text? Text { get => _Text; set => UpdateField(ref _Text, value, nameof(Text)); }

  private Text? _Text;
  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.AxisUnitsLabel.ShapeProperties))]
  public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

  private ShapeProperties? _ShapeProperties;
  /// <summary>
  /// Specifies the tx pr text body.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.AxisUnitsLabel.TxPrTextBody))]
  public TxPrTextBody? TxPrTextBody { get => _TxPrTextBody; set => UpdateField(ref _TxPrTextBody, value, nameof(TxPrTextBody)); }

  private TxPrTextBody? _TxPrTextBody;
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.AxisUnitsLabel.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private ExtensionList? _ExtensionList;
}