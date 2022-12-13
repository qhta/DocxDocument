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
  
  public new DocumentModel.Drawings.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.ShapeStyle? ShapeStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
