namespace DocumentModel.Drawings13;

/// <summary>
/// Defines the NonVisualGroupProperties Class.
/// </summary>
public interface NonVisualGroupProperties
{
  /// <summary>
  /// isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsLegacyGroup { get ; set; }
  
}
