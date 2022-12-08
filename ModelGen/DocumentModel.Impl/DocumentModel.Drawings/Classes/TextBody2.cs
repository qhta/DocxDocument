namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextBody Class.
/// </summary>
public class TextBody2Impl: ModelElementImpl, TextBody2
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
