namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents an internal reference relationship to a DataPart element.
/// </summary>
public static class DataPartReferenceRelationshipConverter
{
  public static DocumentModel.Packaging.DataPartReferenceRelationship? CreateModelElement(DXPack.DataPartReferenceRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DataPartReferenceRelationship();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
