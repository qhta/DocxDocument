namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents an external relationship.
/// </summary>
public static class ExternalRelationshipConverter
{
  public static DMPack.ExternalRelationship? CreateModelElement(DXPack.ExternalRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ExternalRelationship();
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.ExternalRelationship? openXmlElement, DMPack.ExternalRelationship? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ExternalRelationship? value)
    where OpenXmlElementType: DXPack.ExternalRelationship, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
