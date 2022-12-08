namespace DocumentModel.Drawings;

/// <summary>
/// 3D Surface Charts.
/// </summary>
public class Surface3DChartImpl: ModelElementImpl, Surface3DChart
{
  public DocumentFormat.OpenXml.Drawing.Charts.Surface3DChart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Surface3DChart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Wireframe.
  /// </summary>
  public Boolean? Wireframe
  {
    get;
    set;
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public Boolean? VaryColors
  {
    get;
    set;
  }
  
  public Collection<SurfaceChartSeries2>? SurfaceChartSerieses
  {
    get;
    set;
  }
  
  public BandFormats? BandFormats
  {
    get;
    set;
  }
  
  public Collection<UInt32>? AxisIds
  {
    get;
    set;
  }
  
  public Surface3DChartExtensionList? Surface3DChartExtensionList
  {
    get;
    set;
  }
  
}
