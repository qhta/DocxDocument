namespace DocumentModel.Packaging;

/// <summary>
/// Defines the LegacyDiagramTextPart
/// </summary>
public interface ILegacyDiagramTextPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public String? ContentType { get ; set; }
  
  public String? RelationshipType { get ; set; }
  
}
