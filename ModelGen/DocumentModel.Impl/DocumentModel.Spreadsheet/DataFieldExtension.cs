namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataFieldExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IDataField))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IDataField))]
public class DataFieldExtension: IDataFieldExtension
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
