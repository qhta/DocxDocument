namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public interface ExternalData
{
  /// <summary>
  /// Relationship Reference
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Update Automatically.
  /// </summary>
  public Boolean? AutoUpdate { get ; set; }
  
}
