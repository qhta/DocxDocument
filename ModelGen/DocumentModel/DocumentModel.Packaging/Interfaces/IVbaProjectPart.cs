namespace DocumentModel.Packaging;

/// <summary>
/// Defines the VbaProjectPart
/// </summary>
public interface IVbaProjectPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
