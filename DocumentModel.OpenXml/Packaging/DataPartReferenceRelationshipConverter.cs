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
  
  public static bool CompareModelElement(DXPack.DataPartReferenceRelationship? openXmlElement, DMPack.DataPartReferenceRelationship? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      return ok;
    }
    return openXmlElement == null && value == null;
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
