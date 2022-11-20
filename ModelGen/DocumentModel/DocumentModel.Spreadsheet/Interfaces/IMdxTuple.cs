namespace DocumentModel.Spreadsheet;

/// <summary>
/// Tuple MDX Metadata.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.INameIndex))]
public interface IMdxTuple // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Member Index Count
  /// </summary>
  public uint? MemberIndexCount { get ; set; }
  
  /// <summary>
  /// Server Formatting Culture Currency
  /// </summary>
  public string? CultureCurrency { get ; set; }
  
  /// <summary>
  /// Server Formatting String Index
  /// </summary>
  public uint? FormattingStringIndex { get ; set; }
  
  /// <summary>
  /// Server Formatting Built-In Number Format Index
  /// </summary>
  public uint? FormatIndex { get ; set; }
  
  /// <summary>
  /// Server Formatting Background Color
  /// </summary>
  public IHexBinaryValue? BackgroundColor { get ; set; }
  
  /// <summary>
  /// Server Formatting Foreground Color
  /// </summary>
  public IHexBinaryValue? ForegroundColor { get ; set; }
  
  /// <summary>
  /// Server Formatting Italic Font
  /// </summary>
  public bool? Italic { get ; set; }
  
  /// <summary>
  /// Server Formatting Underline Font
  /// </summary>
  public bool? Underline { get ; set; }
  
  /// <summary>
  /// Server Formatting Strikethrough Font
  /// </summary>
  public bool? Strikethrough { get ; set; }
  
  /// <summary>
  /// Server Formatting Bold Font
  /// </summary>
  public bool? Bold { get ; set; }
  
}
