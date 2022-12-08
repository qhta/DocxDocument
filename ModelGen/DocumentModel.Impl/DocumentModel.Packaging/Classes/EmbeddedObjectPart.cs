namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedObjectPart
/// </summary>
public class EmbeddedObjectPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, EmbeddedObjectPart
{
  public new DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.EmbeddedObjectPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
