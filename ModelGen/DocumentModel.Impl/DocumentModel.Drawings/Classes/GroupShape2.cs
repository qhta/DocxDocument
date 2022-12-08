namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public class GroupShape2Impl: DocumentModel.Drawings.GroupShapeTypeImpl, GroupShape2
{
  public new DocumentFormat.OpenXml.Office.Drawing.GroupShape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.GroupShape?)_OpenXmlElement;
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
