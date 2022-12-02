namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedPackagePart
/// </summary>
public interface IEmbeddedPackagePart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? RelationshipType { get ; set; }
  
}
