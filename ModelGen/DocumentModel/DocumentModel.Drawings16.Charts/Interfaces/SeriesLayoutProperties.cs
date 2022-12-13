namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public interface SeriesLayoutProperties
{
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ParentLabelLayout? ParentLabelLayout { get ; set; }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  public DocumentModel.Drawings16.Charts.RegionLabelLayoutEnum? RegionLabelLayout { get ; set; }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  public DocumentModel.Drawings16.Charts.SeriesElementVisibilities? SeriesElementVisibilities { get ; set; }
  
  public Boolean? Aggregation { get ; set; }
  
  public DocumentModel.Drawings16.Charts.Binning? Binning { get ; set; }
  
  public DocumentModel.Drawings16.Charts.Geography? Geography { get ; set; }
  
  public DocumentModel.Drawings16.Charts.Statistics? Statistics { get ; set; }
  
  public DocumentModel.Drawings16.Charts.Subtotals? Subtotals { get ; set; }
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
