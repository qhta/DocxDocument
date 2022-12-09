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
  
  public override GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override GroupShapeProperties1? GroupShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Shape1>? Shapes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<GroupShape2>? GroupShapes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public OfficeArtExtensionList1? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
