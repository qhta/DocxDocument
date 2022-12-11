namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the AllocatedCommandManifest Class.
/// </summary>
public class AllocatedCommandManifestImpl: ModelElementImpl, AllocatedCommandManifest
{
  public DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AllocatedCommandManifestImpl(): base() {}
  
  public AllocatedCommandManifestImpl(DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<AcceleratorKeymapType>? AllocatedCommandManifestEntries
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
