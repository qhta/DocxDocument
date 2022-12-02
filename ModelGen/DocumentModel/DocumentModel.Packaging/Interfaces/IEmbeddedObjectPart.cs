namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedObjectPart
/// </summary>
public interface IEmbeddedObjectPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? RelationshipType { get ; set; }
  
}
