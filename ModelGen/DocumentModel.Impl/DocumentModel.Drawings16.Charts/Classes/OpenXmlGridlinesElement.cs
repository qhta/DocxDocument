namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the OpenXmlGridlinesElement Class.
/// </summary>
public class OpenXmlGridlinesElementImpl: ModelElementImpl, OpenXmlGridlinesElement
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlGridlinesElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlGridlinesElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OpenXmlGridlinesElementImpl(): base() {}
  
  public OpenXmlGridlinesElementImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlGridlinesElement openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public virtual DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public virtual DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
