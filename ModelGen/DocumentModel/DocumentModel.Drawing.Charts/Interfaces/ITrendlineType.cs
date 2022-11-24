namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Trendline Type.
/// </summary>
public interface ITrendlineType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Trendline Type Value
  /// </summary>
  public TrendlineValues? Val { get ; set; }
  
}
