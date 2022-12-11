namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public class ShapeTreeImpl: DocumentModel.Drawings.GroupShapeTypeImpl, ShapeTree
{
  public new DocumentFormat.OpenXml.Office.Drawing.ShapeTree? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.ShapeTree?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeTreeImpl(): base() {}
  
  public ShapeTreeImpl(DocumentFormat.OpenXml.Office.Drawing.ShapeTree openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new GroupShapeProperties? GroupShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Shape? Shape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public GroupShape? GroupShape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
