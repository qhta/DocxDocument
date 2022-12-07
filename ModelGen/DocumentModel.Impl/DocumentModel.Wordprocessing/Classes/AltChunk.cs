namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AltChunk Class.
/// </summary>
public class AltChunkImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.AltChunk>, AltChunk
{
  /// <summary>
  /// External Content Import Properties.
  /// </summary>
  public AltChunkProperties? AltChunkProperties
  {
    get;
    set;
  }
  
}
