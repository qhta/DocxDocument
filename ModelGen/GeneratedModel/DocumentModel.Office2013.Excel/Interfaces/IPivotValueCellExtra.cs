namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the PivotValueCellExtra Class.
/// </summary>
public interface IPivotValueCellExtra // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// in, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? FormatIndex { get ; set; }
  
  /// <summary>
  /// bc, this property is only available in Office 2013 and later.
  /// </summary>
  public IHexBinaryValue? BackgroundColor { get ; set; }
  
  /// <summary>
  /// fc, this property is only available in Office 2013 and later.
  /// </summary>
  public IHexBinaryValue? ForegroundColor { get ; set; }
  
  /// <summary>
  /// i, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Italic { get ; set; }
  
  /// <summary>
  /// un, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Underline { get ; set; }
  
  /// <summary>
  /// st, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Strikethrough { get ; set; }
  
  /// <summary>
  /// b, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Bold { get ; set; }
  
}
