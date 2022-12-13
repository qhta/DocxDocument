namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShape Class.
/// </summary>
public class GroupShapeImpl: DocumentModel.Drawings.GroupShapeTypeImpl, GroupShape
{
  public new DocumentFormat.OpenXml.Office.Drawing.GroupShape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.GroupShape?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GroupShapeImpl(): base() {}
  
  public GroupShapeImpl(DocumentFormat.OpenXml.Office.Drawing.GroupShape openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.GroupShapeProperties? GroupShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Shape? Shape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.GroupShape? ChildGroupShape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
