namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedPackagePart
/// </summary>
public partial class EmbeddedPackagePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, EmbeddedPackagePart
{
  public new DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EmbeddedPackagePartImpl(): base() {}
  
  public EmbeddedPackagePartImpl(DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
