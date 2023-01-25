namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the VmlDrawingPart
/// </summary>
public static class VmlDrawingPartConverter
{
  private static String? GetContentType(DXPack.VmlDrawingPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.VmlDrawingPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  /// <summary>
  /// Gets the ImageParts of the VmlDrawingPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.VmlDrawingPart openXmlElement)
  {
    var collection = new Collection<DMPack.ImagePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.ImagePart>())
    {
      var newItem = DMXPack.ImagePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpImageParts(DXPack.VmlDrawingPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the LegacyDiagramTextParts of the VmlDrawingPart
  /// </summary>
  private static Collection<DMPack.LegacyDiagramTextPart> GetLegacyDiagramTextParts(DXPack.VmlDrawingPart openXmlElement)
  {
    var collection = new Collection<DMPack.LegacyDiagramTextPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.LegacyDiagramTextPart>())
    {
      var newItem = DMXPack.LegacyDiagramTextPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpLegacyDiagramTextParts(DXPack.VmlDrawingPart openXmlElement, Collection<DMPack.LegacyDiagramTextPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.VmlDrawingPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.VmlDrawingPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.VmlDrawingPart? CreateModelElement(DXPack.VmlDrawingPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.VmlDrawingPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.LegacyDiagramTextParts = GetLegacyDiagramTextParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.VmlDrawingPart? openXmlElement, DMPack.VmlDrawingPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpLegacyDiagramTextParts(openXmlElement, value.LegacyDiagramTextParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.VmlDrawingPart? value)
    where OpenXmlElementType: DXPack.VmlDrawingPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetLegacyDiagramTextParts(openXmlElement, value?.LegacyDiagramTextParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
