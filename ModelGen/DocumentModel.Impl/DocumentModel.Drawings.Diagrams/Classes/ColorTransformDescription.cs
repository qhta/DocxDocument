namespace DocumentModel.Drawings.Diagrams;

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
  
  public ColorTransformDescriptionImpl(): base() {}
  
  public ColorTransformDescriptionImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformDescription openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Language
  /// </summary>
  public String? Language
  {
    get => (System.String?)OpenXmlElement?.Language?.Value;
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
    get => (System.String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
}
