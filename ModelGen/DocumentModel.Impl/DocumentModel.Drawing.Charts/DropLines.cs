namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Drop Lines.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
public class DropLines: IDropLines
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
