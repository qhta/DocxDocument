namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Chart Space.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IColorMapOverride))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITextProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDate1904))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IRoundedCorners))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChart))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartSpaceExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExternalData))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPivotSource))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPrintSettings))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IProtection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IUserShapesReference))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IStyle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IEditingLanguage))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Charts.IStyle))]
public class ChartSpace: IChartSpace
{
  /// <summary>
  /// Date1904.
  /// </summary>
  public IDate1904? Date1904
  {
    get;
    set;
  }
  
  /// <summary>
  /// EditingLanguage.
  /// </summary>
  public IEditingLanguage? EditingLanguage
  {
    get;
    set;
  }
  
  /// <summary>
  /// RoundedCorners.
  /// </summary>
  public IRoundedCorners? RoundedCorners
  {
    get;
    set;
  }
  
}
