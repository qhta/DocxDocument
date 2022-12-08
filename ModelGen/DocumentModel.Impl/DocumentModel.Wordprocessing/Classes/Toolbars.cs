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
    get;
    set;
  }
  
  public Collection<ToolbarData>? ToolbarDatas
  {
    get;
    set;
  }
  
}
