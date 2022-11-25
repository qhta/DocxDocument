namespace DocumentModel.Packaging;

/// <summary>
/// Defines the LegacyDiagramTextInfoPart
/// </summary>
public interface ILegacyDiagramTextInfoPart // : DocumentModel.Packaging.ITypedOpenXmlPart
{
  public System.String? ContentType { get ; set; }
  
  public System.String? RelationshipType { get ; set; }
  
}
