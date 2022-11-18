namespace DocumentModel.Office2016.Drawing.Charts;

/// <summary>
/// Defines the ChartDataPointUniqueIDMapEntry Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Charts.IUniqueID))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Charts.IXsdunsignedInt))]
public interface IChartDataPointUniqueIDMapEntry // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// XsdunsignedInt.
  /// </summary>
  public DocumentModel.Office2016.Drawing.Charts.IXsdunsignedInt? XsdunsignedInt { get ; set; }
  
  /// <summary>
  /// UniqueID.
  /// </summary>
  public IUniqueID? UniqueID { get ; set; }
  
}
