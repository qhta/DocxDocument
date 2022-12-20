namespace DocumentModel.Packaging;

/// <summary>
/// Defines the QuickAccessToolbarCustomizationsPart
/// </summary>
public partial class QuickAccessToolbarCustomizationsPartImpl: DocumentModel.Packaging.CustomUIPartImpl, QuickAccessToolbarCustomizationsPart
{
  public new DocumentFormat.OpenXml.Packaging.QuickAccessToolbarCustomizationsPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.QuickAccessToolbarCustomizationsPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public QuickAccessToolbarCustomizationsPartImpl(): base() {}
  
  public QuickAccessToolbarCustomizationsPartImpl(DocumentFormat.OpenXml.Packaging.QuickAccessToolbarCustomizationsPart openXmlElement): base(openXmlElement)
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
