namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotValueCellExtra Class.
/// </summary>
public interface IPivotValueCellExtra // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// in, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? FormatIndex { get ; set; }
  
  /// <summary>
  /// bc, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? BackgroundColor { get ; set; }
  
  /// <summary>
  /// fc, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.IHexBinaryValue? ForegroundColor { get ; set; }
  
  /// <summary>
  /// i, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? Italic { get ; set; }
  
  /// <summary>
  /// un, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? Underline { get ; set; }
  
  /// <summary>
  /// st, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? Strikethrough { get ; set; }
  
  /// <summary>
  /// b, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? Bold { get ; set; }
  
}
