namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public interface ISeriesLayoutProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  public IParentLabelLayout? ParentLabelLayout { get ; set; }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  public RegionLabelLayoutEnum? RegionLabelLayout { get ; set; }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  public ISeriesElementVisibilities? SeriesElementVisibilities { get ; set; }
  
  public Boolean? Aggregation { get ; set; }
  
  public IBinning? Binning { get ; set; }
  
  public IGeography? Geography { get ; set; }
  
  public IStatistics? Statistics { get ; set; }
  
  public ISubtotals? Subtotals { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
