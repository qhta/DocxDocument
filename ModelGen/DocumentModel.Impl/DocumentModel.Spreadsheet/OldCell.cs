namespace DocumentModel.Spreadsheet;

/// <summary>
/// Old Cell Data.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICellFormula))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IInlineString))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICellValue))]
public class OldCell: IOldCell
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? CellReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Index
  /// </summary>
  public uint? StyleIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cell Data Type
  /// </summary>
  public CellValues? DataType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cell Metadata Index
  /// </summary>
  public uint? CellMetaIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Value Metadata Index
  /// </summary>
  public uint? ValueMetaIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Phonetic
  /// </summary>
  public bool? ShowPhonetic
  {
    get;
    set;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public ICellFormula? CellFormula
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cell Value.
  /// </summary>
  public ICellValue? CellValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rich Text Inline.
  /// </summary>
  public IInlineString? InlineString
  {
    get;
    set;
  }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
