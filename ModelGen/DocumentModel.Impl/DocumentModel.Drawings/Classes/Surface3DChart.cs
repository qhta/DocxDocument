namespace DocumentModel.Drawings;

/// <summary>
/// 3D Surface Charts.
/// </summary>
public class Surface3DChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.Surface3DChart>, Surface3DChart
{
  public BandFormats? BandFormats
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
