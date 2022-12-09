namespace DocumentModel.Drawings;

/// <summary>
/// Description.
/// </summary>
public class ColorTransformDescriptionImpl: ModelElementImpl, ColorTransformDescription
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription?)_OpenXmlElement;
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
  /// Description Value
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
