namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistencePart
/// </summary>
public class EmbeddedControlPersistencePartImpl: DocumentModel.Packaging.OpenXmlPartImpl, EmbeddedControlPersistencePart
{
  public new DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EmbeddedControlPersistencePartImpl(): base() {}
  
  public EmbeddedControlPersistencePartImpl(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  public Collection<DocumentModel.Packaging.EmbeddedControlPersistenceBinaryDataPart>? EmbeddedControlPersistenceBinaryDataParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistencePart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
