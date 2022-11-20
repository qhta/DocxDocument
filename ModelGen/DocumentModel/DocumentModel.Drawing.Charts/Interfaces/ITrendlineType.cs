namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Trendline Type.
/// </summary>
public interface ITrendlineType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Trendline Type Value
  /// </summary>
  public TrendlineValues? Val { get ; set; }
  
}
