namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the X values for a chart series, including multi-level string references, number references, literals, and string references.
/// </summary>
public interface XValues
{
  /// <summary>
  ///   Multi-level string reference for X values.
  /// </summary>
  public MultiLevelStringReference? MultiLevelStringReference { get; set; }

  /// <summary>
  ///   Reference to the numeric values used for X values.
  /// </summary>
  public NumberReference? NumberReference { get; set; }

  /// <summary>
  ///   Literal numeric values for X values.
  /// </summary>
  public NumberLiteral? NumberLiteral { get; set; }

  /// <summary>
  ///   Reference to the string values used for X values.
  /// </summary>
  public StringReference? StringReference { get; set; }

  /// <summary>
  ///   Literal string values for X values.
  /// </summary>
  public StringLiteral? StringLiteral { get; set; }
}