namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents an external relationship.
/// </summary>
public static class ExternalRelationshipConverter
{
  public static DocumentModel.Packaging.ExternalRelationship? CreateModelElement(DXPack.ExternalRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ExternalRelationship();
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.ExternalRelationship? openXmlElement, DMPack.ExternalRelationship? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.ExternalRelationship value)
    where OpenXmlElementType: DXPack.ExternalRelationship, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.ExternalRelationship openXmlElement, DMPack.ExternalRelationship value)
  {
  }
}
