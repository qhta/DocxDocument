namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IAggregation))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IBinning))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IGeography))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IParentLabelLayout))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IRegionLabelLayout))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ISeriesElementVisibilities))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IStatistics))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.ISubtotals))]
public class SeriesLayoutProperties: ISeriesLayoutProperties
{
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  public IParentLabelLayout? ParentLabelLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  public IRegionLabelLayout? RegionLabelLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  public ISeriesElementVisibilities? SeriesElementVisibilities
  {
    get;
    set;
  }
  
}
