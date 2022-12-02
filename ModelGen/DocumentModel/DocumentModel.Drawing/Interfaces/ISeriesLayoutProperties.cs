namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public interface ISeriesLayoutProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  public DocumentModel.Drawing.IParentLabelLayout? ParentLabelLayout { get ; set; }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  public DocumentModel.Drawing.RegionLabelLayoutEnum? RegionLabelLayout { get ; set; }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  public DocumentModel.Drawing.ISeriesElementVisibilities? SeriesElementVisibilities { get ; set; }
  
  public System.Boolean? Aggregation { get ; set; }
  
  public DocumentModel.Drawing.IBinning? Binning { get ; set; }
  
  public DocumentModel.Drawing.IGeography? Geography { get ; set; }
  
  public DocumentModel.Drawing.IStatistics? Statistics { get ; set; }
  
  public DocumentModel.Drawing.ISubtotals? Subtotals { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
