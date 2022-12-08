namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StrDataExtensionList Class.
/// </summary>
public class StrDataExtensionListImpl: ModelElementImpl, StrDataExtensionList
{
  public DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<StrDataExtension>? StrDataExtensions
  {
    get;
    set;
  }
  
}
