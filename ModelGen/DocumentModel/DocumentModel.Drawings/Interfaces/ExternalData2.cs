namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public interface ExternalData2
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
