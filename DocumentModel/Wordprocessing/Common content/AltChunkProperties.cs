namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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