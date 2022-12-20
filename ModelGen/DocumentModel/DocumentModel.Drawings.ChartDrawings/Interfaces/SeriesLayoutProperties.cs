namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public partial interface SeriesLayoutProperties
{
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ParentLabelLayout? ParentLabelLayout { get; set; }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.RegionLabelLayoutEnum? RegionLabelLayout { get; set; }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.SeriesElementVisibilities? SeriesElementVisibilities { get; set; }
  
  public Boolean? Aggregation { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.Binning? Binning { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.Geography? Geography { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.Statistics? Statistics { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.Subtotals? Subtotals { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get; set; }
  
}
