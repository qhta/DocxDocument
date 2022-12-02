namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Query Cache.
/// </summary>
public interface IQueryCache // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Cached Query Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IQuery>? Queries { get ; set; }
  
}
