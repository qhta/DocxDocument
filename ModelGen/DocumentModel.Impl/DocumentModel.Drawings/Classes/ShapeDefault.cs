namespace DocumentModel.Drawings;

/// <summary>
/// Shape Default.
/// </summary>
public class ShapeDefaultImpl: DocumentModel.Drawings.DefaultShapeDefinitionTypeImpl, ShapeDefault
{
  public new DocumentFormat.OpenXml.Drawing.ShapeDefault? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ShapeDefault?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeDefaultImpl(): base() {}
  
  public ShapeDefaultImpl(DocumentFormat.OpenXml.Drawing.ShapeDefault openXmlElement): base(openXmlElement)
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
