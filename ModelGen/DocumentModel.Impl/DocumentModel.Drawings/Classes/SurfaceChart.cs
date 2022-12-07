namespace DocumentModel.Drawings;

/// <summary>
/// Surface Charts.
/// </summary>
public class SurfaceChartImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart>, SurfaceChart
{
  public BandFormats? BandFormats
  {
    get;
    set;
  }
  
  public SurfaceChartExtensionList? SurfaceChartExtensionList
  {
    get;
    set;
  }
  
}
