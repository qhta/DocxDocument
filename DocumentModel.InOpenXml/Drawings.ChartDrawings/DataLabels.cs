namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents the collection of data labels and their default settings for a chart series or chart.
/// </summary>
/// <remarks>
///   This class defines the data labels configuration that applies
///   to a series or entire chart, providing both default formatting settings and individual label definitions.
///   The DataLabels class serves as a container that establishes default properties (position, number formatting,
///   styling, text formatting, visibility, and separator) that apply to all labels in the series unless overridden
///   by individual <see cref = "DataLabel"/> definitions. This hierarchical approach enables efficient label management
///   where common formatting is defined once at the series level, while specific data points can have customized
///   labels through the <see cref = "Items"/> collection or suppressed labels through the <see cref = "HiddenDataLabels"/>
///   collection. This structure supports various labeling strategies: showing labels for all data points with uniform
///   formatting, showing labels for select data points with custom formatting, or any combination thereof. The default
///   settings reduce redundancy and simplify label management for charts with many data points, while the individual
///   label collections provide flexibility for emphasizing or suppressing specific values.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.DataLabels))]
public class DataLabels: ModelElementCollection<DataLabel, DXO16DCD.DataLabels, DXO16DCD.DataLabel>
{
  /// <summary>
  /// Specifies the pos.
  /// </summary>
  public DataLabelPos? Pos { get => _Pos; set => UpdateField(ref _Pos, value, nameof(Pos)); }

  private DataLabelPos? _Pos;

  /// <summary>
  /// Specifies the number format.
  /// </summary>
  public NumberFormat? NumberFormat
  {
    get => _NumberFormat;
    set => UpdateField(ref _NumberFormat, value, nameof(NumberFormat));
  }

  private NumberFormat? _NumberFormat;

  /// <summary>
  /// Specifies the shape properties.
  /// </summary>
  public ShapeProperties? ShapeProperties
  {
    get => _ShapeProperties;
    set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties));
  }

  private ShapeProperties? _ShapeProperties;

  /// <summary>
  /// Specifies the tx pr text body.
  /// </summary>
  public TxPrTextBody? TxPrTextBody
  {
    get => _TxPrTextBody;
    set => UpdateField(ref _TxPrTextBody, value, nameof(TxPrTextBody));
  }

  private TxPrTextBody? _TxPrTextBody;

  /// <summary>
  /// Specifies the data label visibilities.
  /// </summary>
  public DataLabelVisibilities? DataLabelVisibilities
  {
    get => _DataLabelVisibilities;
    set => UpdateField(ref _DataLabelVisibilities, value, nameof(DataLabelVisibilities));
  }

  private DataLabelVisibilities? _DataLabelVisibilities;

  /// <summary>
  /// Specifies the separator.
  /// </summary>
  public string? Separator { get => _Separator; set => UpdateField(ref _Separator, value, nameof(Separator)); }

  private string? _Separator;

  /// <summary>
  /// Specifies the hidden data labels.
  /// </summary>
  public HiddenDataLabels? HiddenDataLabels
  {
    get => _HiddenDataLabels;
    set => UpdateField(ref _HiddenDataLabels, value, nameof(HiddenDataLabels));
  }

  private HiddenDataLabels? _HiddenDataLabels;

  /// <summary>
  /// Specifies the extension list.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}