namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public class ChartDataImpl: ModelElementImpl, ChartData
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartDataImpl(): base() {}
  
  public ChartDataImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ExternalData.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExternalData? ExternalData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.Charts.Data? Data
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
