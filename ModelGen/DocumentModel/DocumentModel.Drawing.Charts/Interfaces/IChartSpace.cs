namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Chart Space.
/// </summary>
public interface IChartSpace // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Date1904.
  /// </summary>
  public System.Boolean? Date1904 { get ; set; }
  
  /// <summary>
  /// EditingLanguage.
  /// </summary>
  public System.String? EditingLanguage { get ; set; }
  
  /// <summary>
  /// RoundedCorners.
  /// </summary>
  public System.Boolean? RoundedCorners { get ; set; }
  
}
