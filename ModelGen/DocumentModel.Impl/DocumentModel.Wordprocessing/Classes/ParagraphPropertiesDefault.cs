namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Paragraph Properties.
/// </summary>
public class ParagraphPropertiesDefaultImpl: ModelElementImpl, ParagraphPropertiesDefault
{
  public DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ParagraphPropertiesDefaultImpl(): base() {}
  
  public ParagraphPropertiesDefaultImpl(DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  public ParagraphPropertiesBaseStyle? ParagraphPropertiesBaseStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
