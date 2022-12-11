namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MinorGridlinesGridlines Class.
/// </summary>
public class MinorGridlinesGridlinesImpl: DocumentModel.Drawings.OpenXmlGridlinesElementImpl, MinorGridlinesGridlines
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MinorGridlinesGridlinesImpl(): base() {}
  
  public MinorGridlinesGridlinesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
