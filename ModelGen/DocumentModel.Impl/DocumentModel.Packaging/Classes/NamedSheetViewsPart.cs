namespace DocumentModel.Packaging;

/// <summary>
/// Defines the NamedSheetViewsPart
/// </summary>
public partial class NamedSheetViewsPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, NamedSheetViewsPart
{
  public new DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NamedSheetViewsPartImpl(): base() {}
  
  public NamedSheetViewsPartImpl(DocumentFormat.OpenXml.Packaging.NamedSheetViewsPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
