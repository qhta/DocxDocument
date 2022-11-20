namespace DocumentModel.Spreadsheet;

/// <summary>
/// Conditional Format Value Object.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public class ConditionalFormatValueObject: IConditionalFormatValueObject
{
  /// <summary>
  /// Type
  /// </summary>
  public ConditionalFormatValueObjectValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Greater Than Or Equal
  /// </summary>
  public bool? GreaterThanOrEqual
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
