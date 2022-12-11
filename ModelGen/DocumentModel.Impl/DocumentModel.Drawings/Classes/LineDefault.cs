namespace DocumentModel.Drawings;

/// <summary>
/// Line Default.
/// </summary>
public class LineDefaultImpl: DocumentModel.Drawings.DefaultShapeDefinitionTypeImpl, LineDefault
{
  public new DocumentFormat.OpenXml.Drawing.LineDefault? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LineDefault?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineDefaultImpl(): base() {}
  
  public LineDefaultImpl(DocumentFormat.OpenXml.Drawing.LineDefault openXmlElement): base(openXmlElement)
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
