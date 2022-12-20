namespace DocumentModel.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistenceBinaryDataPart
/// </summary>
public partial class EmbeddedControlPersistenceBinaryDataPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, EmbeddedControlPersistenceBinaryDataPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public EmbeddedControlPersistenceBinaryDataPartImpl(): base() {}
  
  public EmbeddedControlPersistenceBinaryDataPartImpl(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
}
