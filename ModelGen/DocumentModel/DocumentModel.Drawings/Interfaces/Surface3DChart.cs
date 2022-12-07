namespace DocumentModel.Drawings;

/// <summary>
/// 3D Surface Charts.
/// </summary>
public interface Surface3DChart
{
  public BandFormats? BandFormats { get ; set; }
  
  public Surface3DChartExtensionList? Surface3DChartExtensionList { get ; set; }
  
}
