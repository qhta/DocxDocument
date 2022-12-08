namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Content Import Properties.
/// </summary>
public class AltChunkPropertiesImpl: ModelElementImpl, AltChunkProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.AltChunkProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.AltChunkProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Keep Source Formatting on Import.
  /// </summary>
  public Boolean? MatchSource
  {
    get;
    set;
  }
  
}
