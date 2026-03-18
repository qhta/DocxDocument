namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the title displayed for a chart axis.
/// </summary>
/// <remarks>
///   This class defines the title element that labels
///   a chart axis, providing context and meaning to the data represented along that axis. The axis
///   title includes the text content, visual styling properties through shape properties, text formatting
///   properties, and support for custom extensions. Axis titles help users understand what data dimension
///   is represented on each axis (e.g., "Sales Revenue", "Year", "Temperature"). The title can be
///   extensively customized in terms of appearance, positioning, and text formatting to match the
///   chart's overall design and ensure readability.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.AxisTitle))]
public class AxisTitle: ModelElement<DXO16DCD.AxisTitle>
{
  /// <summary>
  /// Specifies the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.AxisTitle.Text))]
  public Text? Text { get => _Text; set => UpdateField(ref _Text, value, nameof(Text)); }

  private Text? _Text;

  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.AxisTitle.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties;
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  /// Specifies the tx pr text body.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.AxisTitle.TxPrTextBody))]
  public TxPrTextBody? TxPrTextBody
  {
    get => _TxPrTextBody;
    set => UpdateField(ref _TxPrTextBody, value, nameof(TxPrTextBody));
  }

  private TxPrTextBody? _TxPrTextBody;

  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.AxisTitle.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}