namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Title.
/// </summary>
public partial class ColorDefinitionTitleImpl: ModelElementImpl, ColorDefinitionTitle
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorDefinitionTitleImpl(): base() {}
  
  public ColorDefinitionTitleImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ColorDefinitionTitle openXmlElement): base(openXmlElement)
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
