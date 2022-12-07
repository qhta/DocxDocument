namespace DocumentModel.Drawings;

/// <summary>
/// Minor Gridlines.
/// </summary>
public class MinorGridlinesImpl: DocumentModel.Drawings.ChartLinesTypeImpl, MinorGridlines
{
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
