namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheFieldExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ICacheField))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ICachedUniqueNames))]
public class CacheFieldExtension: ICacheFieldExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
