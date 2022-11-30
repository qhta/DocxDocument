namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedPackagePart
/// </summary>
public interface IEmbeddedPackagePart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetFileExtension { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
}
