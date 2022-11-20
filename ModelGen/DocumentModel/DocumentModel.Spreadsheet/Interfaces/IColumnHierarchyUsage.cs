namespace DocumentModel.Spreadsheet;

/// <summary>
/// Column OLAP Hierarchies.
/// </summary>
public interface IColumnHierarchyUsage // : DocumentFormat.OpenXml.Spreadsheet.HierarchyUsageType
{
  /// <summary>
  /// Hierarchy Usage
  /// </summary>
  public int? Value { get ; set; }
  
}
