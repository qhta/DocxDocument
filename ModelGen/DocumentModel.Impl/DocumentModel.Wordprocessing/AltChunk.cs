namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AltChunk Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAltChunkProperties))]
public class AltChunk: IAltChunk
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// External Content Import Properties.
  /// </summary>
  public IAltChunkProperties? AltChunkProperties
  {
    get;
    set;
  }
  
}
