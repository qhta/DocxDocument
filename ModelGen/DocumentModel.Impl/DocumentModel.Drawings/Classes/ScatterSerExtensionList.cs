namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScatterSerExtensionList Class.
/// </summary>
public class ScatterSerExtensionListImpl: ModelElementImpl, ScatterSerExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<ScatterSerExtension>? ScatterSerExtensions
  {
    get;
    set;
  }
  
}
