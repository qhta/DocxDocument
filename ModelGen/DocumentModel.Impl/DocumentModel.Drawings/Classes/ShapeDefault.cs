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
  
  public override ShapeProperties4? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override ShapeStyle2? ShapeStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override ExtensionList4? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
