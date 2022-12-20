namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the AxisDataSourceType Class.
/// </summary>
public partial interface AxisDataSourceType3
{
  /// <summary>
  /// Multi Level String Reference.
  /// </summary>
  public DocumentModel.Drawings.Charts.MultiLevelStringReference? MultiLevelStringReference { get; set; }
  
  /// <summary>
  /// Number Reference.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberReference? NumberReference { get; set; }
  
  /// <summary>
  /// Number Literal.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral { get; set; }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringReference? StringReference { get; set; }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  public DocumentModel.Drawings.Charts.StringLiteral? StringLiteral { get; set; }
  
}
