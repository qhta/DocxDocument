namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the NumberDataSourceType Class.
/// </summary>
public partial class NumberDataSourceType
{
  /// <summary>
  /// Number Reference.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberReference? NumberReference { get; set; }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral { get; set; }
  
}
