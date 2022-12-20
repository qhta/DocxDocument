namespace DocumentModel.Packaging;

/// <summary>
/// Represents an internal reference relationship to a DataPart element.
/// </summary>
public partial class DataPartReferenceRelationshipImpl: DocumentModel.Packaging.ReferenceRelationshipImpl, DataPartReferenceRelationship
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
  
  /// <summary>
  /// Gets the referenced target DataPart.
  /// </summary>
  public DocumentModel.Packaging.DataPart? DataPart
  {
    get
    {
      if (OpenXmlElement?.DataPart != null)
        return new DocumentModel.Packaging.DataPartImpl(OpenXmlElement.DataPart);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
        if (value is DocumentModel.Packaging.DataPartImpl valueImpl)
          if (valueImpl.OpenXmlElement != null)
              OpenXmlElement.SetDataPart(valueImpl.OpenXmlElement);
    }
  }
  
}
