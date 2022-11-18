namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchies Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICacheHierarchy))]
public interface ICacheHierarchies // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Hierarchy Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
