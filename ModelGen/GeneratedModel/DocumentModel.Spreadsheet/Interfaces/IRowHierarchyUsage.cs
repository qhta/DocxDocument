namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row OLAP Hierarchies.
/// </summary>
public interface IRowHierarchyUsage // : DocumentFormat.OpenXml.Spreadsheet.HierarchyUsageType
{
  /// <summary>
  /// Hierarchy Usage
  /// </summary>
  public int? Value { get ; set; }
  
}
