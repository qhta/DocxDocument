namespace DocumentModel.Drawings;

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
  
  public Clear? Clear { get ; set; }
  
}
