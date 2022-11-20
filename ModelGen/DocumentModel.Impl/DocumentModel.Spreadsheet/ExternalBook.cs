namespace DocumentModel.Spreadsheet;

/// <summary>
/// External Workbook.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExternalDefinedNames))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISheetDataSet))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISheetNames))]
[ChildElementInfo(typeof(DocumentModel.Office.SpreadSheetML.Y2021.ExtLinks2021.IExternalBookAlternateUrls))]
public class ExternalBook: IExternalBook
{
  /// <summary>
  /// Relationship to supporting book file path
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Alternate URLs and identifiers of the external book, this property is only available in Microsoft365 and later..
  /// </summary>
  public IExternalBookAlternateUrls? ExternalBookAlternateUrls
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sheet names of supporting book.
  /// </summary>
  public ISheetNames? SheetNames
  {
    get;
    set;
  }
  
  /// <summary>
  /// Defined names associated with supporting book..
  /// </summary>
  public IExternalDefinedNames? ExternalDefinedNames
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cached worksheet data associated with supporting book.
  /// </summary>
  public ISheetDataSet? SheetDataSet
  {
    get;
    set;
  }
  
}
