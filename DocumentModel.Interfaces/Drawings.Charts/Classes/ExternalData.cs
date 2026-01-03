namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ExternalData Class.
/// </summary>
public interface ExternalData: IModelElement
{
  /// <summary>
  ///   Relationship Reference
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   Update Automatically.
  /// </summary>
  public bool? AutoUpdate { get; set; }
}