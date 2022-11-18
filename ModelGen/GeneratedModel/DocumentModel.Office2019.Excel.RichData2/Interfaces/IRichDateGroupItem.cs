namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the RichDateGroupItem Class.
/// </summary>
public interface IRichDateGroupItem // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// key, this property is only available in Office 2019 and later.
  /// </summary>
  public string? Key { get ; set; }
  
  /// <summary>
  /// Year
  /// </summary>
  public ushort? Year { get ; set; }
  
  /// <summary>
  /// Month
  /// </summary>
  public ushort? Month { get ; set; }
  
  /// <summary>
  /// Day
  /// </summary>
  public ushort? Day { get ; set; }
  
  /// <summary>
  /// Hour
  /// </summary>
  public ushort? Hour { get ; set; }
  
  /// <summary>
  /// Minute
  /// </summary>
  public ushort? Minute { get ; set; }
  
  /// <summary>
  /// Second
  /// </summary>
  public ushort? Second { get ; set; }
  
  /// <summary>
  /// Date Time Grouping
  /// </summary>
  public DateTimeGrouping? DateTimeGrouping { get ; set; }
  
}
