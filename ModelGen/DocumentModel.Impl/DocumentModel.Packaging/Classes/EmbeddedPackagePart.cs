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
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
