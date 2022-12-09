namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties8? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
