namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistenceBinaryDataPart
/// </summary>
public class EmbeddedControlPersistenceBinaryDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, EmbeddedControlPersistenceBinaryDataPart
{
  public new DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
