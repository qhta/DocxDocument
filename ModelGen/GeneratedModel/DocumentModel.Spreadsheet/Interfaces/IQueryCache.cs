namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Query Cache.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IQuery))]
public interface IQueryCache // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Cached Query Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
