namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextBody Class.
/// </summary>
public class TextBodyImpl: ModelElementImpl, TextBody
{
  public DocumentFormat.OpenXml.Office.Drawing.TextBody? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.TextBody?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextBodyImpl(): base() {}
  
  public TextBodyImpl(DocumentFormat.OpenXml.Office.Drawing.TextBody openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Body Properties.
  /// </summary>
  public DocumentModel.Drawings.BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public DocumentModel.Drawings.ListStyle? ListStyle
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
