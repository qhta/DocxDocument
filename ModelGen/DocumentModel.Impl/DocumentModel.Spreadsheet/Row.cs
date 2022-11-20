namespace DocumentModel.Spreadsheet;

/// <summary>
/// Row.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICell))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public class Row: IRow
{
  /// <summary>
  /// Row Index
  /// </summary>
  public uint? RowIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Spans
  /// </summary>
  public List<string>? Spans
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
  /// Custom Format
  /// </summary>
  public bool? CustomFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// Row Height
  /// </summary>
  public double? Height
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hidden
  /// </summary>
  public bool? Hidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Custom Height
  /// </summary>
  public bool? CustomHeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Outline Level
  /// </summary>
  public byte? OutlineLevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Collapsed
  /// </summary>
  public bool? Collapsed
  {
    get;
    set;
  }
  
  /// <summary>
  /// Thick Top Border
  /// </summary>
  public bool? ThickTop
  {
    get;
    set;
  }
  
  /// <summary>
  /// Thick Bottom
  /// </summary>
  public bool? ThickBot
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
  /// dyDescent, this property is only available in Office 2010 and later.
  /// </summary>
  public double? DyDescent
  {
    get;
    set;
  }
  
}
