namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HighLowLines Class.
/// </summary>
public class HighLowLinesImpl: DocumentModel.Drawings.ChartLinesTypeImpl, HighLowLines
{
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
