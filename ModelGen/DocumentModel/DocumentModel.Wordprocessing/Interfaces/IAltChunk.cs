namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AltChunk Class.
/// </summary>
public interface IAltChunk // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// External Content Import Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IAltChunkProperties? AltChunkProperties { get ; set; }
  
}
