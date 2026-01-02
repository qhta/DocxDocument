namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ExternalData Class.
/// </summary>
public class ExternalData: ModelElement
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