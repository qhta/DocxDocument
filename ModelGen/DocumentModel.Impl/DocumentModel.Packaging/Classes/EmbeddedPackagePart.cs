namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedPackagePart
/// </summary>
public class EmbeddedPackagePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, EmbeddedPackagePart
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
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.EmbeddedPackagePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
