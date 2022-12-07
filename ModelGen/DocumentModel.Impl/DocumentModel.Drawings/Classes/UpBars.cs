namespace DocumentModel.Drawings;

/// <summary>
/// Up Bars.
/// </summary>
public class UpBarsImpl: DocumentModel.Drawings.UpDownBarTypeImpl, UpBars
{
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
