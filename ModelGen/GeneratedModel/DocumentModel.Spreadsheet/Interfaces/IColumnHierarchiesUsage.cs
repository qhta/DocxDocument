namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ColumnHierarchiesUsage Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColumnHierarchyUsage))]
public interface IColumnHierarchiesUsage // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Items Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
