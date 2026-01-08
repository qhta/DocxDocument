namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the data for a category axis, including multi-level string references, number references, literals, and string references.
/// </summary>
public interface CategoryAxisData
{
  /// <summary>
  ///   Multi-level string reference for category axis data.
  /// </summary>
  public MultiLevelStringReference? MultiLevelStringReference { get; set; }

  /// <summary>
  ///   Reference to the numeric values used for category axis data.
  /// </summary>
  public NumberReference? NumberReference { get; set; }

  /// <summary>
  ///   Literal numeric values for category axis data.
  /// </summary>
  public NumberLiteral? NumberLiteral { get; set; }

  /// <summary>
  ///   Reference to the string values used for category axis data.
  /// </summary>
  public StringReference? StringReference { get; set; }

  /// <summary>
  ///   Literal string values for category axis data.
  /// </summary>
  public StringLiteral? StringLiteral { get; set; }
}