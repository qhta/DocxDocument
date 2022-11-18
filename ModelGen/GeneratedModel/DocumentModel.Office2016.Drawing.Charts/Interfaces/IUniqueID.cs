namespace DocumentModel.Office2016.Drawing.Charts;

/// <summary>
/// Defines the UniqueID Class.
/// </summary>
public interface IUniqueID // : DocumentFormat.OpenXml.Office2016.Drawing.Charts.UniqueIDChart
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Val { get ; set; }
  
}
