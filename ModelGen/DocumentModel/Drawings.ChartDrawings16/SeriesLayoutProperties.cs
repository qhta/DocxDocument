namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the SeriesLayoutProperties Class.
/// </summary>
public partial class SeriesLayoutProperties
{
  
  /// <summary>
  ///   ParentLabelLayout.
  /// </summary>
  public DMDCD16.ParentLabelLayout? ParentLabelLayout { get; set; }
  
  
  /// <summary>
  ///   RegionLabelLayout.
  /// </summary>
  public DMDCD16.RegionLabelLayoutEnum? RegionLabelLayout { get; set; }
  
  
  /// <summary>
  ///   SeriesElementVisibilities.
  /// </summary>
  public DMDCD16.SeriesElementVisibilities? SeriesElementVisibilities { get; set; }
  
  public DMDCD16.Aggregation? Aggregation { get; set; }
  
  public DMDCD16.Binning? Binning { get; set; }
  
  public DMDCD16.Geography? Geography { get; set; }
  
  public DMDCD16.Statistics? Statistics { get; set; }
  
  public DMDCD16.Subtotals? Subtotals { get; set; }
  
  public DMDCD16.ExtensionList? ExtensionList { get; set; }
  
}
