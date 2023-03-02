namespace DocumentModel.Drawings;

/// <summary>
///   Text Line Break.
/// </summary>
public record Break
{
  /// <summary>
  ///   Text Run Properties.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
}