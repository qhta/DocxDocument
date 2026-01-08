namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the data source for numeric values in a chart.
///   This interface allows specifying either a reference to an external data source or literal values provided directly.
/// </summary>
public interface NumberDataSourceType
{
  /// <summary>
  ///   Reference to a numeric data source, typically used for formula-based values.
  /// </summary>
  public NumberReference? NumberReference { get; set; }

  /// <summary>
  ///   Literal numeric values provided directly for the data source.
  /// </summary>
  public NumberLiteral? NumberLiteral { get; set; }
}