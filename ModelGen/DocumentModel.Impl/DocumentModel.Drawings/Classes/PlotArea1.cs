namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
public class PlotArea1Impl: ModelElementImpl, PlotArea1
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotArea?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// PlotAreaRegion.
  /// </summary>
  public PlotAreaRegion? PlotAreaRegion
  {
    get;
    set;
  }
  
  public Collection<Axis>? Axises
  {
    get;
    set;
  }
  
  public ShapeProperties6? ShapeProperties
  {
    get;
    set;
  }
  
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
