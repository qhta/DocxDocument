namespace DocumentModel.Spreadsheet;

/// <summary>
/// Error Value.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITuples))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMemberPropertyIndex))]
public interface IErrorItem // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public string? Val { get ; set; }
  
  /// <summary>
  /// Unused Item
  /// </summary>
  public bool? Unused { get ; set; }
  
  /// <summary>
  /// Calculated Item
  /// </summary>
  public bool? Calculated { get ; set; }
  
  /// <summary>
  /// Item Caption
  /// </summary>
  public string? Caption { get ; set; }
  
  /// <summary>
  /// Member Property Count
  /// </summary>
  public uint? PropertyCount { get ; set; }
  
  /// <summary>
  /// Format Index
  /// </summary>
  public uint? FormatIndex { get ; set; }
  
  /// <summary>
  /// background Color
  /// </summary>
  public IHexBinaryValue? BackgroundColor { get ; set; }
  
  /// <summary>
  /// Foreground Color
  /// </summary>
  public IHexBinaryValue? ForegroundColor { get ; set; }
  
  /// <summary>
  /// Italic
  /// </summary>
  public bool? Italic { get ; set; }
  
  /// <summary>
  /// Underline
  /// </summary>
  public bool? Underline { get ; set; }
  
  /// <summary>
  /// Strikethrough
  /// </summary>
  public bool? Strikethrough { get ; set; }
  
  /// <summary>
  /// Bold
  /// </summary>
  public bool? Bold { get ; set; }
  
  /// <summary>
  /// Tuples.
  /// </summary>
  public ITuples? Tuples { get ; set; }
  
}
