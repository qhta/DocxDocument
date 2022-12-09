namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextProperties Class.
/// </summary>
public class TextProperties1Impl: DocumentModel.Drawings.TextBodyType1Impl, TextProperties1
{
  public new DocumentFormat.OpenXml.Drawing.Charts.TextProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.TextProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Paragraph>? Paragraphs
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
