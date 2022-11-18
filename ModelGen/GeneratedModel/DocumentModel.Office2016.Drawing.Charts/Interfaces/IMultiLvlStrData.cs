namespace DocumentModel.Office2016.Drawing.Charts;

/// <summary>
/// Defines the MultiLvlStrData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILevel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPointCount))]
public interface IMultiLvlStrData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public IPointCount? PointCount { get ; set; }
  
}
