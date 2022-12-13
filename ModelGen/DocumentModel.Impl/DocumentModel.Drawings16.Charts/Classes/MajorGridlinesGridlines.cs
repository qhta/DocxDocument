namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the MajorGridlinesGridlines Class.
/// </summary>
public class MajorGridlinesGridlinesImpl: DocumentModel.Drawings16.Charts.OpenXmlGridlinesElementImpl, MajorGridlinesGridlines
{
  public new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MajorGridlinesGridlinesImpl(): base() {}
  
  public MajorGridlinesGridlinesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
