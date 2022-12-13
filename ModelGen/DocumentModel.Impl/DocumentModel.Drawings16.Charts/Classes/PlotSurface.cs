namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the PlotSurface Class.
/// </summary>
public class PlotSurfaceImpl: ModelElementImpl, PlotSurface
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PlotSurfaceImpl(): base() {}
  
  public PlotSurfaceImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotSurface openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
