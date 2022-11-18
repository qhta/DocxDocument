namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the CustomRichFilter Class.
/// </summary>
public interface ICustomRichFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// key, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Key { get ; set; }
  
  /// <summary>
  /// Filter Comparison Operator
  /// </summary>
  public FilterOperator? Operator { get ; set; }
  
  /// <summary>
  /// Top or Bottom Value
  /// </summary>
  public string? Val { get ; set; }
  
}
