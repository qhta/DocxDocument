namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents an internal reference relationship to a DataPart element.
/// </summary>
public static class DataPartReferenceRelationshipConverter
{
  public static DocumentModel.Packaging.DataPartReferenceRelationship? CreateModelElement(DocumentFormat.OpenXml.Packaging.DataPartReferenceRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DataPartReferenceRelationship();
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DataPartReferenceRelationship? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.DataPartReferenceRelationship, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
