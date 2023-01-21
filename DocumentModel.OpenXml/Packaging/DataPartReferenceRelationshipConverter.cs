namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents an internal reference relationship to a DataPart element.
/// </summary>
public static class DataPartReferenceRelationshipConverter
{
  public static DMPack.DataPartReferenceRelationship? CreateModelElement(DXPack.DataPartReferenceRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.DataPartReferenceRelationship();
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.DataPartReferenceRelationship? value)
    where OpenXmlElementType: DXPack.DataPartReferenceRelationship, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
