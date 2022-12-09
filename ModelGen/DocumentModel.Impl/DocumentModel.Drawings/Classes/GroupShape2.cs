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
