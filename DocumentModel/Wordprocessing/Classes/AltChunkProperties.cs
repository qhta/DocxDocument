namespace DocumentModel.Wordprocessing;

/// <summary>
///   External Content Import Properties.
/// </summary>
public class AltChunkProperties: ModelElement
{
  /// <summary>
  ///   Keep Source Formatting on Import.
  /// </summary>
  public Boolean? MatchSource { get; set; }
}