namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Title.
/// </summary>
public partial class StyleDefinitionTitleImpl: ModelElementImpl, StyleDefinitionTitle
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public StyleDefinitionTitleImpl(): base() {}
  
  public StyleDefinitionTitleImpl(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinitionTitle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Natural Language
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
