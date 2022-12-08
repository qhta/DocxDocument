namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public interface SeriesLayoutProperties
{
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  public ParentLabelLayout? ParentLabelLayout { get ; set; }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  public RegionLabelLayoutEnum? RegionLabelLayout { get ; set; }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  public SeriesElementVisibilities? SeriesElementVisibilities { get ; set; }
  
  public Boolean? Aggregation { get ; set; }
  
  public Binning? Binning { get ; set; }
  
  public Geography? Geography { get ; set; }
  
  public Statistics? Statistics { get ; set; }
  
  public Subtotals? Subtotals { get ; set; }
  
  public ExtensionList2? ExtensionList { get ; set; }
  
}
