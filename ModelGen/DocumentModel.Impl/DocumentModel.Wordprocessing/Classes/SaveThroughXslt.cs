namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public class SaveThroughXsltImpl: ModelElementImpl, SaveThroughXslt
{
  public DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SaveThroughXslt?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// XSL Transformation Location
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Local Identifier for XSL Transform
  /// </summary>
  public String? SolutionId
  {
    get;
    set;
  }
  
}
