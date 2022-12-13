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
  
  public EmbeddedControlPersistenceBinaryDataPartImpl(): base() {}
  
  public EmbeddedControlPersistenceBinaryDataPartImpl(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.EmbeddedControlPersistenceBinaryDataPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
