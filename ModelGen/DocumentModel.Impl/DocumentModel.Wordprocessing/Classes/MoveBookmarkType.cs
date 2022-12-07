namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveBookmarkType Class.
/// </summary>
public class MoveBookmarkTypeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.MoveBookmarkType>, MoveBookmarkType
{
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml
  {
    get => (DisplacedByCustomXmlKind?)OpenXmlElement?.DisplacedByCustomXml?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DisplacedByCustomXml = (DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues?)value;
    }
  }
  
}
