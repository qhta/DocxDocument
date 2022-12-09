namespace DocumentModel.Drawings;

/// <summary>
/// Text Body.
/// </summary>
public class TextBody1Impl: ModelElementImpl, TextBody1
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.TextBody? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.TextBody?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Body Properties.
  /// </summary>
  public BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public ListStyle? ListStyle
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
