namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the data source for an axis in a chart.
///   This class allows specifying different types of data sources, such as references or literals for numbers and strings, to define the values displayed along a chart axis.
/// </summary>
[OpenXmlType(typeof(DXDC.AxisDataSourceType))]
public partial class AxisDataSourceType : ModelElement<DXDC.AxisDataSourceType>
{
  /// <summary>
  ///   Reference to a multi-level string data source, used for hierarchical or grouped axis labels.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.MultiLevelStringReference))]
  public MultiLevelStringReference? MultiLevelStringReference
  {
    get => _MultiLevelStringReference;
    set => UpdateField(ref _MultiLevelStringReference, value, nameof(MultiLevelStringReference));
  }

  private MultiLevelStringReference? _MultiLevelStringReference;

  /// <summary>
  ///   Reference to a numeric data source, typically pointing to a cell range containing numeric values.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.NumberReference))]
  public NumberReference? NumberReference
  {
    get => _NumberReference;
    set => UpdateField(ref _NumberReference, value, nameof(NumberReference));
  }

  private NumberReference? _NumberReference;

  /// <summary>
  ///   Literal numeric values provided directly for the axis data source.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.NumberLiteral))]
  public NumberLiteral? NumberLiteral
  {
    get => _NumberLiteral;
    set => UpdateField(ref _NumberLiteral, value, nameof(NumberLiteral));
  }

  private NumberLiteral? _NumberLiteral;

  /// <summary>
  ///   Reference to a string data source, typically pointing to a cell range containing text values.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.StringReference))]
  public StringReference? StringReference
  {
    get => _StringReference;
    set => UpdateField(ref _StringReference, value, nameof(StringReference));
  }

  private StringReference? _StringReference;

  /// <summary>
  ///   Literal string values provided directly for the axis data source.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.StringLiteral))]
  public StringLiteral? StringLiteral
  {
    get => _StringLiteral;
    set => UpdateField(ref _StringLiteral, value, nameof(StringLiteral));
  }

  private StringLiteral? _StringLiteral;
}


