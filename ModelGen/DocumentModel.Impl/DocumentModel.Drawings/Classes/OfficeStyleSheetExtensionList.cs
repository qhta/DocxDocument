namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtensionList Class.
/// </summary>
public class OfficeStyleSheetExtensionListImpl: ModelElementImpl, OfficeStyleSheetExtensionList
{
  public DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.OfficeStyleSheetExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<OfficeStyleSheetExtension>? OfficeStyleSheetExtensions
  {
    get;
    set;
  }
  
}
