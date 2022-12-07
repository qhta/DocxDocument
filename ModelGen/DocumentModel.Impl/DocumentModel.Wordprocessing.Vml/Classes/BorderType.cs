namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public class BorderTypeImpl: ModelElement<DocumentFormat.OpenXml.Vml.Wordprocessing.BorderType>, BorderType
{
  /// <summary>
  /// Border Style
  /// </summary>
  public BorderKind? Type
  {
    get => (BorderKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Wordprocessing.BorderValues?)value;
    }
  }
  
}
