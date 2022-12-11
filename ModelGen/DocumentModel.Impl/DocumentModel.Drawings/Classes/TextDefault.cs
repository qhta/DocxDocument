namespace DocumentModel.Drawings;

/// <summary>
/// Text Default.
/// </summary>
public class TextDefaultImpl: DocumentModel.Drawings.DefaultShapeDefinitionTypeImpl, TextDefault
{
  public new DocumentFormat.OpenXml.Drawing.TextDefault? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TextDefault?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextDefaultImpl(): base() {}
  
  public TextDefaultImpl(DocumentFormat.OpenXml.Drawing.TextDefault openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new ShapeStyle? ShapeStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
