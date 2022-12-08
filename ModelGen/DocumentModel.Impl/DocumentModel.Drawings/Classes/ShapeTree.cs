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
    get;
    set;
  }
  
  public override GroupShapeProperties2? GroupShapeProperties
  {
    get;
    set;
  }
  
  public Collection<Shape2>? Shapes
  {
    get;
    set;
  }
  
  public Collection<GroupShape2>? GroupShapes
  {
    get;
    set;
  }
  
  public OfficeArtExtensionList5? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
