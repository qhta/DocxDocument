namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the TabularSlicerCacheItems Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ITabularSlicerCacheItem))]
public interface ITabularSlicerCacheItems // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// count, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Count { get ; set; }
  
}
