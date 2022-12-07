namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SeriesLines Class.
/// </summary>
public class SeriesLinesImpl: DocumentModel.Drawings.ChartLinesTypeImpl, SeriesLines
{
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
