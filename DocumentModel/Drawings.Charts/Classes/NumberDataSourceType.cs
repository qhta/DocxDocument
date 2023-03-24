namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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