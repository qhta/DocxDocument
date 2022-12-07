namespace DocumentModel.Drawings;

/// <summary>
/// Drop Lines.
/// </summary>
public class DropLinesImpl: DocumentModel.Drawings.ChartLinesTypeImpl, DropLines
{
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
