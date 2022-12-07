namespace DocumentModel.Drawings;

/// <summary>
/// Down Bars.
/// </summary>
public class DownBarsImpl: DocumentModel.Drawings.UpDownBarTypeImpl, DownBars
{
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
