namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AltChunk Class.
/// </summary>
public interface IAltChunk // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// External Content Import Properties.
  /// </summary>
  public IAltChunkProperties? AltChunkProperties { get ; set; }
  
}
