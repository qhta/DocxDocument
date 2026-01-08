namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents the Y values for a chart series, including references and literals.
/// </summary>
public interface YValues
{
  /// <summary>
  ///   Reference to the numeric values used for Y values.
  /// </summary>
  public NumberReference? NumberReference { get; set; }

  /// <summary>
  ///   Literal numeric values for Y values.
  /// </summary>
  public NumberLiteral? NumberLiteral { get; set; }
}