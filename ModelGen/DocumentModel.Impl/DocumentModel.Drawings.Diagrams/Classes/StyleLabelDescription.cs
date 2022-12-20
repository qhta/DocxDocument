namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Style Label Description.
/// </summary>
public partial class StyleLabelDescriptionImpl: ModelElementImpl, StyleLabelDescription
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public StyleLabelDescriptionImpl(): base() {}
  
  public StyleLabelDescriptionImpl(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabelDescription openXmlElement): base(openXmlElement)
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
