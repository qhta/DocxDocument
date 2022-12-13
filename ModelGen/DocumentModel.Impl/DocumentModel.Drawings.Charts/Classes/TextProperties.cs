namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the TextProperties Class.
/// </summary>
public class TextPropertiesImpl: DocumentModel.Drawings.Charts.TextBodyTypeImpl, TextProperties
{
  public new DocumentFormat.OpenXml.Drawing.Charts.TextProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.TextProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextPropertiesImpl(): base() {}
  
  public TextPropertiesImpl(DocumentFormat.OpenXml.Drawing.Charts.TextProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Paragraph? Paragraph
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
