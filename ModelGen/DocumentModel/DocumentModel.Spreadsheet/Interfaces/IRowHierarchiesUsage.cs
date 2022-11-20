namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RowHierarchiesUsage Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRowHierarchyUsage))]
public interface IRowHierarchiesUsage // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Item Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
