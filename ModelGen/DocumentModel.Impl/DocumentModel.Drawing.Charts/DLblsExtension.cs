namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IShowDataLabelsRange))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IShowLeaderLines))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ILeaderLines))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ILayout))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IChartText))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IDataLabelFieldTable))]
public class DLblsExtension: IDLblsExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
