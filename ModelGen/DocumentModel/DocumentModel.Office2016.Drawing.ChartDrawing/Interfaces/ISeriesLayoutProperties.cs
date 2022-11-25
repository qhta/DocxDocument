namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public interface ISeriesLayoutProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.IParentLabelLayout? ParentLabelLayout { get ; set; }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum? RegionLabelLayout { get ; set; }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.ISeriesElementVisibilities? SeriesElementVisibilities { get ; set; }
  
}
