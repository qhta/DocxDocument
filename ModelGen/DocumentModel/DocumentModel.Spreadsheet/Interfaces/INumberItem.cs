namespace DocumentModel.Spreadsheet;

/// <summary>
/// Numeric.
/// </summary>
public interface INumberItem // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Value
  /// </summary>
  public System.Double? Val { get ; set; }
  
  /// <summary>
  /// Unused Item
  /// </summary>
  public System.Boolean? Unused { get ; set; }
  
  /// <summary>
  /// Calculated Item
  /// </summary>
  public System.Boolean? Calculated { get ; set; }
  
  /// <summary>
  /// Caption
  /// </summary>
  public System.String? Caption { get ; set; }
  
  /// <summary>
  /// Member Property Count
  /// </summary>
  public System.UInt32? PropertyCount { get ; set; }
  
  /// <summary>
  /// Format Index
  /// </summary>
  public System.UInt32? FormatIndex { get ; set; }
  
  /// <summary>
  /// Background Color
  /// </summary>
  public DocumentModel.IHexBinaryValue? BackgroundColor { get ; set; }
  
  /// <summary>
  /// Foreground Color
  /// </summary>
  public DocumentModel.IHexBinaryValue? ForegroundColor { get ; set; }
  
  /// <summary>
  /// Italic
  /// </summary>
  public System.Boolean? Italic { get ; set; }
  
  /// <summary>
  /// Underline
  /// </summary>
  public System.Boolean? Underline { get ; set; }
  
  /// <summary>
  /// Strikethrough
  /// </summary>
  public System.Boolean? Strikethrough { get ; set; }
  
  /// <summary>
  /// Bold
  /// </summary>
  public System.Boolean? Bold { get ; set; }
  
}
