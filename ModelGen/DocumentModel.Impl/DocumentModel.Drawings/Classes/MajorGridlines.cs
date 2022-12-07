namespace DocumentModel.Drawings;

/// <summary>
/// Major Gridlines.
/// </summary>
public class MajorGridlinesImpl: DocumentModel.Drawings.ChartLinesTypeImpl, MajorGridlines
{
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
