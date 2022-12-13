namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public interface Chart
{
  /// <summary>
  /// ChartTitle.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ChartTitle? ChartTitle { get ; set; }
  
  /// <summary>
  /// PlotArea.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PlotArea? PlotArea { get ; set; }
  
  /// <summary>
  /// Legend.
  /// </summary>
  public DocumentModel.Drawings16.Charts.Legend? Legend { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
