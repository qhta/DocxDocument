namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public interface ChartData
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ExternalData? ExternalData { get ; set; }
  
  public DocumentModel.Drawings.ChartDrawings.Data? Data { get ; set; }
  
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get ; set; }
  
}
