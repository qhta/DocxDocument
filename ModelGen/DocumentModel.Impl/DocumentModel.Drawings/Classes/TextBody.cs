namespace DocumentModel.Drawings;

/// <summary>
/// Shape Text Body.
/// </summary>
public class TextBodyImpl: ModelElementImpl, TextBody
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextBodyImpl(): base() {}
  
  public TextBodyImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.TextBody openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  
  public Paragraph? Paragraph
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
