namespace DocumentModel.Drawings;

/// <summary>
/// Shape Text Body.
/// </summary>
public class TextBody3Impl: ModelElementImpl, TextBody3
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody?)_OpenXmlElement;
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
