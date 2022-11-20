namespace DocumentModel.Spreadsheet;

/// <summary>
/// Numeric.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITuples))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMemberPropertyIndex))]
public class NumberItem: INumberItem
{
  /// <summary>
  /// Value
  /// </summary>
  public double? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Unused Item
  /// </summary>
  public bool? Unused
  {
    get;
    set;
  }
  
  /// <summary>
  /// Calculated Item
  /// </summary>
  public bool? Calculated
  {
    get;
    set;
  }
  
  /// <summary>
  /// Caption
  /// </summary>
  public string? Caption
  {
    get;
    set;
  }
  
  /// <summary>
  /// Member Property Count
  /// </summary>
  public uint? PropertyCount
  {
    get;
    set;
  }
  
  /// <summary>
  /// Format Index
  /// </summary>
  public uint? FormatIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Background Color
  /// </summary>
  public IHexBinaryValue? BackgroundColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Foreground Color
  /// </summary>
  public IHexBinaryValue? ForegroundColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Italic
  /// </summary>
  public bool? Italic
  {
    get;
    set;
  }
  
  /// <summary>
  /// Underline
  /// </summary>
  public bool? Underline
  {
    get;
    set;
  }
  
  /// <summary>
  /// Strikethrough
  /// </summary>
  public bool? Strikethrough
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bold
  /// </summary>
  public bool? Bold
  {
    get;
    set;
  }
  
}
