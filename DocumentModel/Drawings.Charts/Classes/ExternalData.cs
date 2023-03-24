namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ExternalData Class.
/// </summary>
public class ExternalData: ModelElement
{
  /// <summary>
  ///   Relationship Reference
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Update Automatically.
  /// </summary>
  public Boolean? AutoUpdate { get; set; }
}