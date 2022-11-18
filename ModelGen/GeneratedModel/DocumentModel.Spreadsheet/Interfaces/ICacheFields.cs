namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICacheField))]
public interface ICacheFields // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
