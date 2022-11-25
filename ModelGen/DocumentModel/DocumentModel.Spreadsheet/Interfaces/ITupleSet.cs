namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Set.
/// </summary>
public interface ITupleSet // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Number of Tuples
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  /// <summary>
  /// Maximum Rank Requested
  /// </summary>
  public System.Int32? MaxRank { get ; set; }
  
  /// <summary>
  /// MDX Set Definition
  /// </summary>
  public System.String? SetDefinition { get ; set; }
  
  /// <summary>
  /// Set Sort Order
  /// </summary>
  public DocumentModel.Spreadsheet.SortKind? SortType { get ; set; }
  
  /// <summary>
  /// Query Failed
  /// </summary>
  public System.Boolean? QueryFailed { get ; set; }
  
}
