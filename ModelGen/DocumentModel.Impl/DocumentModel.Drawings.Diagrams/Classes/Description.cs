namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Description.
/// </summary>
public partial class DescriptionImpl: ModelElementImpl, Description
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagrams.Description? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Description?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DescriptionImpl(): base() {}
  
  public DescriptionImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Description openXmlElement): base(openXmlElement)
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
  /// Value
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
