namespace DocumentModel.Spreadsheet;

/// <summary>
/// Dialog Sheet Format Properties.
/// </summary>
public interface ISheetFormatProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Base Column Width
  /// </summary>
  public System.UInt32? BaseColumnWidth { get ; set; }
  
  /// <summary>
  /// Default Column Width
  /// </summary>
  public System.Double? DefaultColumnWidth { get ; set; }
  
  /// <summary>
  /// Default Row Height
  /// </summary>
  public System.Double? DefaultRowHeight { get ; set; }
  
  /// <summary>
  /// Custom Height
  /// </summary>
  public System.Boolean? CustomHeight { get ; set; }
  
  /// <summary>
  /// Hidden By Default
  /// </summary>
  public System.Boolean? ZeroHeight { get ; set; }
  
  /// <summary>
  /// Thick Top Border
  /// </summary>
  public System.Boolean? ThickTop { get ; set; }
  
  /// <summary>
  /// Thick Bottom Border
  /// </summary>
  public System.Boolean? ThickBottom { get ; set; }
  
  /// <summary>
  /// Maximum Outline Row
  /// </summary>
  public System.Byte? OutlineLevelRow { get ; set; }
  
  /// <summary>
  /// Column Outline Level
  /// </summary>
  public System.Byte? OutlineLevelColumn { get ; set; }
  
  /// <summary>
  /// dyDescent, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Double? DyDescent { get ; set; }
  
}
