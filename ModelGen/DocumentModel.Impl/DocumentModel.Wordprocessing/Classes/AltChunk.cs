namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AltChunk Class.
/// </summary>
public class AltChunkImpl: ModelElementImpl, AltChunk
{
  public DocumentFormat.OpenXml.Wordprocessing.AltChunk? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.AltChunk?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// External Content Import Properties.
  /// </summary>
  public AltChunkProperties? AltChunkProperties
  {
    get;
    set;
  }
  
}
