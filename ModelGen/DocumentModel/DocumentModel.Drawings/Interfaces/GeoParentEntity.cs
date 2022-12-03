namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoParentEntity Class.
/// </summary>
public interface GeoParentEntity // : System.Boolean
{
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get ; set; }
  
}
