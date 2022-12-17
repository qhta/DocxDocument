namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal reference relationship to a DataPart element.
/// </summary>
public class DataPartReferenceRelationshipImpl: DocumentModel.Packaging.ReferenceRelationshipImpl, DataPartReferenceRelationship
{
  public new DocumentFormat.OpenXml.Packaging.DataPartReferenceRelationship? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DataPartReferenceRelationship?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataPartReferenceRelationshipImpl(): base() {}
  
  public DataPartReferenceRelationshipImpl(DocumentFormat.OpenXml.Packaging.DataPartReferenceRelationship openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
}
