namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Chart Space.
/// </summary>
public interface IChartSpace // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Date1904.
  /// </summary>
  public IDate1904? Date1904 { get ; set; }
  
  /// <summary>
  /// EditingLanguage.
  /// </summary>
  public IEditingLanguage? EditingLanguage { get ; set; }
  
  /// <summary>
  /// RoundedCorners.
  /// </summary>
  public IRoundedCorners? RoundedCorners { get ; set; }
  
  /// <summary>
  /// Gets the ChartPart associated with this element.
  /// </summary>
  public ChartPart? ChartPart { get ; set; }
  
}
