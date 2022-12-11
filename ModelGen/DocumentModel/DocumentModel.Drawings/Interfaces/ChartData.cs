namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public interface ChartData
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  public ExternalData? ExternalData { get ; set; }
  
  public Data? Data { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
