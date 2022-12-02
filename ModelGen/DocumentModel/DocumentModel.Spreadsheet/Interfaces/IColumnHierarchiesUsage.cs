namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnHierarchiesUsage Class.
/// </summary>
public interface IColumnHierarchiesUsage // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Items Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IHierarchyUsageType>? ColumnHierarchyUsages { get ; set; }
  
}
