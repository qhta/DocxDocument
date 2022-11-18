namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the RichTop10 Class.
/// </summary>
public interface IRichTop10 // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// key, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Key { get ; set; }
  
  /// <summary>
  /// Top
  /// </summary>
  public bool? Top { get ; set; }
  
  /// <summary>
  /// Filter by Percent
  /// </summary>
  public bool? Percent { get ; set; }
  
  /// <summary>
  /// Top or Bottom Value
  /// </summary>
  public double? Val { get ; set; }
  
  /// <summary>
  /// Filter Value
  /// </summary>
  public double? FilterValue { get ; set; }
  
}
