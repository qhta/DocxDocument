namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the values for a chart series.
///   This interface defines the data source for the values, which can be either a reference to a range or a set of literal values.
/// </summary>
public interface Values
{
  /// <summary>
  ///   Reference to a numeric data source.
  /// </summary>
  public NumberReference? NumberReference { get; set; }

  /// <summary>
  ///   Literal numeric values provided directly.
  /// </summary>
  public NumberLiteral? NumberLiteral { get; set; }
}