namespace DocumentModel.Wordprocessing;

/// <summary>
///   External Content Import Properties.
/// </summary>
public record AltChunkProperties
{
  /// <summary>
  ///   Keep Source Formatting on Import.
  /// </summary>
  public Boolean? MatchSource { get; set; }
}