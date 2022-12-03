namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AltChunk Class.
/// </summary>
public interface AltChunk // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// External Content Import Properties.
  /// </summary>
  public AltChunkProperties? AltChunkProperties { get ; set; }
  
}
