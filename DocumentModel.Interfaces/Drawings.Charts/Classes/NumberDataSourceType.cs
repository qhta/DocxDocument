namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumberDataSourceType Class.
/// </summary>
public interface NumberDataSourceType: IModelElement
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