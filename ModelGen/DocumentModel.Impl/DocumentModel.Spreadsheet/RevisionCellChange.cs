namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Cell Change.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IOldCell))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IOldDifferentialFormat))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.INewDifferentialFormat))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.INewCell))]
public class RevisionCellChange: IRevisionCellChange
{
  /// <summary>
  /// Revision Id
  /// </summary>
  public uint? RevisionId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Revision From Rejection
  /// </summary>
  public bool? Ua
  {
    get;
    set;
  }
  
  /// <summary>
  /// Revision Undo Rejected
  /// </summary>
  public bool? Ra
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Formatting
  /// </summary>
  public bool? OldFormatting
  {
    get;
    set;
  }
  
  /// <summary>
  /// Row Column Formatting Change
  /// </summary>
  public bool? RowColumnFormattingAffected
  {
    get;
    set;
  }
  
  /// <summary>
  /// Style Revision
  /// </summary>
  public bool? StyleRevision
  {
    get;
    set;
  }
  
  /// <summary>
  /// Formatting
  /// </summary>
  public bool? Format
  {
    get;
    set;
  }
  
  /// <summary>
  /// Number Format Id
  /// </summary>
  public uint? NumberFormatId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Quote Prefix
  /// </summary>
  public bool? QuotePrefix
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Quote Prefix
  /// </summary>
  public bool? OldQuotePrefix
  {
    get;
    set;
  }
  
  /// <summary>
  /// Phonetic Text
  /// </summary>
  public bool? HasPhoneticText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Phonetic Text
  /// </summary>
  public bool? OldPhoneticText
  {
    get;
    set;
  }
  
  /// <summary>
  /// End of List  Formula Update
  /// </summary>
  public bool? EndOfListFormulaUpdate
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Cell Data.
  /// </summary>
  public IOldCell? OldCell
  {
    get;
    set;
  }
  
  /// <summary>
  /// New Cell Data.
  /// </summary>
  public INewCell? NewCell
  {
    get;
    set;
  }
  
  /// <summary>
  /// Old Formatting Information.
  /// </summary>
  public IOldDifferentialFormat? OldDifferentialFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// New Formatting Information.
  /// </summary>
  public INewDifferentialFormat? NewDifferentialFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
