namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistenceBinaryDataPart
/// </summary>
[RelationshipUri("http://schemas.microsoft.com/office/2006/relationships/activeXControlBinary")]
public interface EmbeddedControlPersistenceBinaryDataPart // : DocumentModel.Packaging.OpenXmlPart
{
  public String? RelationshipType { get ; set; }
  
}
