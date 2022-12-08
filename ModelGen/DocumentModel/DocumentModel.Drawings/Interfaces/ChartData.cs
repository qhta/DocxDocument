namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public interface ChartData
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  public ExternalData1? ExternalData { get ; set; }
  
  public Collection<Data1>? Datas { get ; set; }
  
  public ExtensionList2? ExtensionList { get ; set; }
  
}
