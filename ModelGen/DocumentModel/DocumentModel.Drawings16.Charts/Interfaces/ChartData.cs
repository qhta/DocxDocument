namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public interface ChartData
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExternalData? ExternalData { get ; set; }
  
  public DocumentModel.Drawings16.Charts.Data? Data { get ; set; }
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
