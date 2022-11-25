namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the CacheHierarchy Class.
/// </summary>
public interface ICacheHierarchy // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// aggregatedColumn, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Int32? AggregatedColumn { get ; set; }
  
}
