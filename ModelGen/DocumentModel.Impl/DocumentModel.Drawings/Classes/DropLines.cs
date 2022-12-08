namespace DocumentModel.Drawings;

/// <summary>
/// Drop Lines.
/// </summary>
public class DropLinesImpl: DocumentModel.Drawings.ChartLinesTypeImpl, DropLines
{
  public new DocumentFormat.OpenXml.Drawing.Charts.DropLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DropLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
