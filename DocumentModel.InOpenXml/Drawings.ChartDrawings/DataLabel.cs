namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents a label that displays information for a specific data point in a chart.
/// </summary>
/// <remarks>
///   This class defines a data label element that provides textual
///   or visual information about individual data points in a chart. Data labels help users understand specific
///   values, categories, series names, or other contextual information directly on the chart without requiring
///   reference to axes or legends. Each data label is associated with a specific data point through an index,
///   and can be positioned relative to its data point (above, below, left, right, center, etc.). The label
///   supports comprehensive formatting including number formatting for numeric values, visual styling through
///   shape properties, text formatting, visibility controls for different label components (value, category name,
///   series name, etc.), and custom separators when multiple information types are displayed. Data labels can
///   significantly enhance chart readability by making key values immediately visible, though excessive use
///   may clutter the visualization. They are particularly valuable in charts with few data points or when
///   precise values need to be emphasized.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.DataLabel))]
public class DataLabel: ModelElement<DXO16DCD.DataLabel>
{
  /// <summary>
  /// Specifies the idx.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataLabel.Idx))]
  public UInt32? Idx { get => _Idx; set => UpdateField(ref _Idx, value, nameof(Idx)); }
  private UInt32? _Idx;
  /// <summary>
  /// Specifies the pos.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataLabel.Pos))]
  public DataLabelPos? Pos { get => _Pos; set => UpdateField(ref _Pos, value, nameof(Pos)); }
  private DataLabelPos? _Pos;
  /// <summary>
  /// Specifies the number format.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataLabel.NumberFormat))]
  public NumberFormat? NumberFormat
  {
    get => _NumberFormat;
    set => UpdateField(ref _NumberFormat, value, nameof(NumberFormat));
  }
  private NumberFormat? _NumberFormat;
  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataLabel.ShapeProperties))]
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties;
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }
  private ShapeProperties? _ShapeProperties;
  /// <summary>
  /// Specifies the tx pr text body.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataLabel.TxPrTextBody))]
  public TxPrTextBody? TxPrTextBody
  {
    get => _TxPrTextBody;
    set => UpdateField(ref _TxPrTextBody, value, nameof(TxPrTextBody));
  }
  private TxPrTextBody? _TxPrTextBody;
  /// <summary>
  /// Specifies the data label visibilities.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataLabel.DataLabelVisibilities))]
  public DataLabelVisibilities? DataLabelVisibilities
  {
    get => _DataLabelVisibilities;
    set => UpdateField(ref _DataLabelVisibilities, value, nameof(DataLabelVisibilities));
  }
  private DataLabelVisibilities? _DataLabelVisibilities;
  /// <summary>
  /// Specifies the separator xsd string.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataLabel.SeparatorXsdstring))]
  public string? SeparatorXsdString
  {
    get => _SeparatorXsdString;
    set => UpdateField(ref _SeparatorXsdString, value, nameof(SeparatorXsdString));
  }
  private string? _SeparatorXsdString;
  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.DataLabel.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }
  private ExtensionList? _ExtensionList;
}