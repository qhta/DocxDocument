namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the RichFilter Class.
/// </summary>
public interface IRichFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// key, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Key { get ; set; }
  
  /// <summary>
  /// val, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Val { get ; set; }
  
  /// <summary>
  /// blank, this property is only available in Office 2019 and later.
  /// </summary>
  public bool? Blank { get ; set; }
  
  /// <summary>
  /// nodata, this property is only available in Office 2019 and later.
  /// </summary>
  public bool? Nodata { get ; set; }
  
}
