namespace DocumentModel.Drawings;

/// <summary>
/// Shape Text Body.
/// </summary>
public class TextBody2Impl: ModelElementImpl, TextBody2
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
