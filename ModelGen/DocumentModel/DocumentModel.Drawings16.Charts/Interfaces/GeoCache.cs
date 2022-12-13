namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoCache Class.
/// </summary>
public interface GeoCache
{
  /// <summary>
  /// provider, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Provider { get ; set; }
  
  public String? Xsdbase64Binary { get ; set; }
  
  public DocumentModel.Drawings16.Charts.Clear? Clear { get ; set; }
  
}
