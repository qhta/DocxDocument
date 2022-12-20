namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public partial class SaveThroughXsltImpl: ModelElementImpl, SaveThroughXslt
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SaveThroughXsltImpl(): base() {}
  
  public SaveThroughXsltImpl(DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// XSL Transformation Location
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Local Identifier for XSL Transform
  /// </summary>
  public String? SolutionId
  {
    get => (System.String?)OpenXmlElement?.SolutionId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SolutionId = (System.String?)value;
    }
  }
  
}
