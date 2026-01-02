namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumberDataSourceType Class.
/// </summary>
public class NumberDataSourceType: ModelElement
{
  /// <summary>
  ///   Number Reference.
  /// </summary>
  public NumberReference? NumberReference { get; set; }
  /// <summary>
  ///   Number Literal.
  /// </summary>
  public NumberLiteral? NumberLiteral { get; set; }
}