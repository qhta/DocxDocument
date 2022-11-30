namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Query Cache.
/// </summary>
public interface IQueryCache // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Cached Query Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IQuery>? Queries { get ; set; }
  
}
