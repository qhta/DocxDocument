namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TextProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITextFields))]
public class TextProperties: ITextProperties
{
  /// <summary>
  /// prompt
  /// </summary>
  public bool? Prompt
  {
    get;
    set;
  }
  
  /// <summary>
  /// fileType
  /// </summary>
  public FileTypeValues? FileType
  {
    get;
    set;
  }
  
  /// <summary>
  /// codePage
  /// </summary>
  public uint? CodePage
  {
    get;
    set;
  }
  
  /// <summary>
  /// characterSet
  /// </summary>
  public string? TextCharacterSet
  {
    get;
    set;
  }
  
  /// <summary>
  /// firstRow
  /// </summary>
  public uint? FirstRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// sourceFile
  /// </summary>
  public string? SourceFile
  {
    get;
    set;
  }
  
  /// <summary>
  /// delimited
  /// </summary>
  public bool? Delimited
  {
    get;
    set;
  }
  
  /// <summary>
  /// decimal
  /// </summary>
  public string? Decimal
  {
    get;
    set;
  }
  
  /// <summary>
  /// thousands
  /// </summary>
  public string? Thousands
  {
    get;
    set;
  }
  
  /// <summary>
  /// tab
  /// </summary>
  public bool? TabAsDelimiter
  {
    get;
    set;
  }
  
  /// <summary>
  /// space
  /// </summary>
  public bool? Space
  {
    get;
    set;
  }
  
  /// <summary>
  /// comma
  /// </summary>
  public bool? Comma
  {
    get;
    set;
  }
  
  /// <summary>
  /// semicolon
  /// </summary>
  public bool? Semicolon
  {
    get;
    set;
  }
  
  /// <summary>
  /// consecutive
  /// </summary>
  public bool? Consecutive
  {
    get;
    set;
  }
  
  /// <summary>
  /// qualifier
  /// </summary>
  public QualifierValues? Qualifier
  {
    get;
    set;
  }
  
  /// <summary>
  /// delimiter
  /// </summary>
  public string? Delimiter
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextFields.
  /// </summary>
  public ITextFields? TextFields
  {
    get;
    set;
  }
  
}
