namespace DocumentModel.Drawings;

/// <summary>
/// Title.
/// </summary>
public class Title1Impl: ModelElementImpl, Title1
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Title? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Title?)_OpenXmlElement;
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
