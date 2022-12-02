namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowHierarchiesUsage Class.
/// </summary>
public interface IRowHierarchiesUsage // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Item Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IHierarchyUsageType>? RowHierarchyUsages { get ; set; }
  
}
