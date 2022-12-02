namespace DocumentModel.Spreadsheet;

/// <summary>
/// No Value.
/// </summary>
public interface IMissingItem // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unused Item
  /// </summary>
  public Boolean? Unused { get ; set; }
  
  /// <summary>
  /// Calculated Item
  /// </summary>
  public Boolean? Calculated { get ; set; }
  
  /// <summary>
  /// Caption
  /// </summary>
  public String? Caption { get ; set; }
  
  /// <summary>
  /// Member Property Count
  /// </summary>
  public UInt32? PropertyCount { get ; set; }
  
  /// <summary>
  /// Format Index
  /// </summary>
  public UInt32? FormatIndex { get ; set; }
  
  /// <summary>
  /// background Color
  /// </summary>
  public DocumentModel.IHexBinaryValue? BackgroundColor { get ; set; }
  
  /// <summary>
  /// Foreground Color
  /// </summary>
  public DocumentModel.IHexBinaryValue? ForegroundColor { get ; set; }
  
  /// <summary>
  /// Italic
  /// </summary>
  public Boolean? Italic { get ; set; }
  
  /// <summary>
  /// Underline
  /// </summary>
  public Boolean? Underline { get ; set; }
  
  /// <summary>
  /// Strikethrough
  /// </summary>
  public Boolean? Strikethrough { get ; set; }
  
  /// <summary>
  /// Bold
  /// </summary>
  public Boolean? Bold { get ; set; }
  
  public Collection<ITuples>? Tupleses { get ; set; }
  
  public Collection<Int32>? MemberPropertyIndexs { get ; set; }
  
}
