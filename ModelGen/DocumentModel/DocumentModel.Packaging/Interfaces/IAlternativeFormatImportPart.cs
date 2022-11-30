namespace DocumentModel.Packaging;

/// <summary>
/// Defines the AlternativeFormatImportPart
/// </summary>
public interface IAlternativeFormatImportPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? RelationshipType { get ; set; }
  
  public System.String? TargetFileExtension { get ; set; }
  
  public System.String? TargetName { get ; set; }
  
  public System.String? TargetPath { get ; set; }
  
}
