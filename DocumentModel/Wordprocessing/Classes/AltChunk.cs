namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the AltChunk Class.
/// </summary>
public class AltChunk
{
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   External Content Import Properties.
  /// </summary>
  public AltChunkProperties? AltChunkProperties { get; set; }
}