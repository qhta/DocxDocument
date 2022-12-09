namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextBody Class.
/// </summary>
public class TextBody3Impl: ModelElementImpl, TextBody3
{
  public DocumentFormat.OpenXml.Office.Drawing.TextBody? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.TextBody?)_OpenXmlElement;
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
