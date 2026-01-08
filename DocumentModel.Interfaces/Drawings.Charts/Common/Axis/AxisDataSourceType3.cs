namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the data source for an axis in a chart, supporting multiple reference and literal types.
///   This interface allows specifying different types of data sources, such as references or literals for numbers and strings, to define the values displayed along a chart axis.
/// </summary>
public interface AxisDataSourceType3
{
  /// <summary>
  ///   Reference to a multi-level string data source, used for hierarchical or grouped axis labels.
  /// </summary>
  public MultiLevelStringReference? MultiLevelStringReference { get; set; }

  /// <summary>
  ///   Reference to a numeric data source, typically pointing to a cell range containing numeric values.
  /// </summary>
  public NumberReference? NumberReference { get; set; }

  /// <summary>
  ///   Literal numeric values provided directly for the axis data source.
  /// </summary>
  public NumberLiteral? NumberLiteral { get; set; }

  /// <summary>
  ///   Reference to a string data source, typically pointing to a cell range containing text values.
  /// </summary>
  public StringReference? StringReference { get; set; }

  /// <summary>
  ///   Literal string values provided directly for the axis data source.
  /// </summary>
  public StringLiteral? StringLiteral { get; set; }
}