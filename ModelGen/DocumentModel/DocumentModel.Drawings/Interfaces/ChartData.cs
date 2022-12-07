namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public interface ChartData
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  public ExternalData2? ExternalData { get ; set; }
  
  public ExtensionList2? ExtensionList { get ; set; }
  
}
