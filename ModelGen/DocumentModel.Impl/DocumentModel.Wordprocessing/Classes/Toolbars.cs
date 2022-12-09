namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
public class ToolbarsImpl: ModelElementImpl, Toolbars
{
  public DocumentFormat.OpenXml.Office.Word.Toolbars? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.Toolbars?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<AllocatedCommandManifest>? AllocatedCommandManifests
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<ToolbarData>? ToolbarDatas
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
