namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LinearShadeProperties Class.
/// </summary>
public class LinearShadePropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.LinearShadeProperties>, LinearShadeProperties
{
  /// <summary>
  /// scaled, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffKind? Scaled
  {
    get => (OnOffKind?)OpenXmlElement?.Scaled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Scaled = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
    }
  }
  
}
