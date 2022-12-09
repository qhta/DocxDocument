namespace DocumentModel.Drawings;

/// <summary>
/// Description.
/// </summary>
public class DescriptionImpl: ModelElementImpl, Description
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Description? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Description?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Language
  /// </summary>
  public String? Language
  {
    get => (String?)OpenXmlElement?.Language?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Language = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val
  {
    get => (String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
}
