namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnHierarchiesUsage Class.
/// </summary>
public interface IColumnHierarchiesUsage // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Items Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IHierarchyUsageType>? ColumnHierarchyUsages { get ; set; }
  
}
