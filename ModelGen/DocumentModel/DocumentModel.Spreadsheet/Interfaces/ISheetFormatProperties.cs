namespace DocumentModel.Spreadsheet;

/// <summary>
/// Dialog Sheet Format Properties.
/// </summary>
public interface ISheetFormatProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Base Column Width
  /// </summary>
  public UInt32? BaseColumnWidth { get ; set; }
  
  /// <summary>
  /// Default Column Width
  /// </summary>
  public Double? DefaultColumnWidth { get ; set; }
  
  /// <summary>
  /// Default Row Height
  /// </summary>
  public Double? DefaultRowHeight { get ; set; }
  
  /// <summary>
  /// Custom Height
  /// </summary>
  public Boolean? CustomHeight { get ; set; }
  
  /// <summary>
  /// Hidden By Default
  /// </summary>
  public Boolean? ZeroHeight { get ; set; }
  
  /// <summary>
  /// Thick Top Border
  /// </summary>
  public Boolean? ThickTop { get ; set; }
  
  /// <summary>
  /// Thick Bottom Border
  /// </summary>
  public Boolean? ThickBottom { get ; set; }
  
  /// <summary>
  /// Maximum Outline Row
  /// </summary>
  public Byte? OutlineLevelRow { get ; set; }
  
  /// <summary>
  /// Column Outline Level
  /// </summary>
  public Byte? OutlineLevelColumn { get ; set; }
  
  /// <summary>
  /// dyDescent, this property is only available in Office 2010 and later.
  /// </summary>
  public Double? DyDescent { get ; set; }
  
}
