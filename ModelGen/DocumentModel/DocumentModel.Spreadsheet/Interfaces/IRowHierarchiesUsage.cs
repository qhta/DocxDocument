namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowHierarchiesUsage Class.
/// </summary>
public interface IRowHierarchiesUsage // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Item Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IHierarchyUsageType>? RowHierarchyUsages { get ; set; }
  
}
