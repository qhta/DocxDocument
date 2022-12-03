namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoCache Class.
/// </summary>
public interface GeoCache // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// provider, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Provider { get ; set; }
  
  public Collection<String>? Xsdbase64Binaries { get ; set; }
  
  public Collection<Clear>? Clears { get ; set; }
  
}
