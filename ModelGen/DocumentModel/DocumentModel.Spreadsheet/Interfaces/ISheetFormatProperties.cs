namespace DocumentModel.Spreadsheet;

/// <summary>
/// Dialog Sheet Format Properties.
/// </summary>
public interface ISheetFormatProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Base Column Width
  /// </summary>
  public uint? BaseColumnWidth { get ; set; }
  
  /// <summary>
  /// Default Column Width
  /// </summary>
  public double? DefaultColumnWidth { get ; set; }
  
  /// <summary>
  /// Default Row Height
  /// </summary>
  public double? DefaultRowHeight { get ; set; }
  
  /// <summary>
  /// Custom Height
  /// </summary>
  public bool? CustomHeight { get ; set; }
  
  /// <summary>
  /// Hidden By Default
  /// </summary>
  public bool? ZeroHeight { get ; set; }
  
  /// <summary>
  /// Thick Top Border
  /// </summary>
  public bool? ThickTop { get ; set; }
  
  /// <summary>
  /// Thick Bottom Border
  /// </summary>
  public bool? ThickBottom { get ; set; }
  
  /// <summary>
  /// Maximum Outline Row
  /// </summary>
  public byte? OutlineLevelRow { get ; set; }
  
  /// <summary>
  /// Column Outline Level
  /// </summary>
  public byte? OutlineLevelColumn { get ; set; }
  
  /// <summary>
  /// dyDescent, this property is only available in Office 2010 and later.
  /// </summary>
  public double? DyDescent { get ; set; }
  
}
