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
    return openXmlElement == null && value == null;
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
