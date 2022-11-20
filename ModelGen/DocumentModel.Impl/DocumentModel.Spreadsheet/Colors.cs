namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Colors Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IIndexedColors))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMruColors))]
public class Colors: IColors
{
  /// <summary>
  /// Color Indexes.
  /// </summary>
  public IIndexedColors? IndexedColors
  {
    get;
    set;
  }
  
  /// <summary>
  /// MRU Colors.
  /// </summary>
  public IMruColors? MruColors
  {
    get;
    set;
  }
  
}
