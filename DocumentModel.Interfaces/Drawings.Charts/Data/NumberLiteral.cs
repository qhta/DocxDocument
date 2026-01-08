namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a set of literal numeric values for a chart.
/// </summary>
public interface NumberLiteral
{
  /// <summary>
  ///   Format code applied to the numeric values.
  /// </summary>
  public string? FormatCode { get; set; }

  /// <summary>
  ///   Number of numeric points in the literal value set.
  /// </summary>
  public UInt32? PointCount { get; set; }

  /// <summary>
  ///   Collection of numeric points containing the literal values.
  /// </summary>
  public NumericPoints NumericPoints { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional customization.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}