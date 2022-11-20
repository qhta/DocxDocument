namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFields Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICacheField))]
public class CacheFields: ICacheFields
{
  /// <summary>
  /// Field Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
