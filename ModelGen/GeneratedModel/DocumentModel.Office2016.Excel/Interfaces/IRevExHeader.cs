namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Defines the RevExHeader Class.
/// </summary>
public interface IRevExHeader // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// minRev, this property is only available in Office 2016 and later.
  /// </summary>
  public ulong? MinRev { get ; set; }
  
  /// <summary>
  /// maxRev, this property is only available in Office 2016 and later.
  /// </summary>
  public ulong? MaxRev { get ; set; }
  
  /// <summary>
  /// time, this property is only available in Office 2016 and later.
  /// </summary>
  public DateTime? Time { get ; set; }
  
}
