namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotValueCellExtra Class.
/// </summary>
public interface PivotValueCellExtra // : System.Boolean
{
  /// <summary>
  /// in, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? FormatIndex { get ; set; }
  
  /// <summary>
  /// bc, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? BackgroundColor { get ; set; }
  
  /// <summary>
  /// fc, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? ForegroundColor { get ; set; }
  
  /// <summary>
  /// i, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Italic { get ; set; }
  
  /// <summary>
  /// un, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Underline { get ; set; }
  
  /// <summary>
  /// st, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Strikethrough { get ; set; }
  
  /// <summary>
  /// b, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Bold { get ; set; }
  
}
