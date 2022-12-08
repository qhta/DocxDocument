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
    get;
    set;
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public ListStyle? ListStyle
  {
    get;
    set;
  }
  
  public Collection<Paragraph>? Paragraphs
  {
    get;
    set;
  }
  
}
