namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Drop Lines.
/// </summary>
public class DropLinesImpl: DocumentModel.Drawings.Charts.ChartLinesTypeImpl, DropLines
{
  public new DocumentFormat.OpenXml.Drawing.Charts.DropLines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DropLines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DropLinesImpl(): base() {}
  
  public DropLinesImpl(DocumentFormat.OpenXml.Drawing.Charts.DropLines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
