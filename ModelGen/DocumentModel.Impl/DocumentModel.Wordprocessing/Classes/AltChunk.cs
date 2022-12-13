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
  
  public AltChunkImpl(): base() {}
  
  public AltChunkImpl(DocumentFormat.OpenXml.Wordprocessing.AltChunk openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// External Content Import Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.AltChunkProperties? AltChunkProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
