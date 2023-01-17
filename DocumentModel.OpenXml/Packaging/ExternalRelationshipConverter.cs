namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents an external relationship.
/// </summary>
public static class ExternalRelationshipConverter
{
  public static DocumentModel.Packaging.ExternalRelationship? CreateModelElement(DocumentFormat.OpenXml.Packaging.ExternalRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ExternalRelationship();
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ExternalRelationship? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ExternalRelationship, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
