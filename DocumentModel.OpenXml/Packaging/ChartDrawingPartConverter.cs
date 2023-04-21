namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartDrawingPart
/// </summary>
public static class ChartDrawingPartConverter
{
  private static String? GetContentType(DXPack.ChartDrawingPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.ChartDrawingPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ChartDrawingPart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.ChartDrawingPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.ChartDrawingPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.ChartDrawingPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.ChartDrawingPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDC.UserShapes? GetUserShapes(DXPack.ChartDrawingPart openXmlElement)
  {
      return DMXDC.UserShapesConverter.CreateModelElement(openXmlElement?.RootElement as DXDC.UserShapes);
  }
  
  private static bool CmpUserShapes(DXPack.ChartDrawingPart openXmlElement, DMDC.UserShapes? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetUserShapes(DXPack.ChartDrawingPart openXmlElement, DMDC.UserShapes? value)
  {
    if (value != null)
    {
       var rootElement = DMXDC.UserShapesConverter.CreateOpenXmlElement<DXDC.UserShapes>(value);
       if (rootElement != null)
         openXmlElement.UserShapes = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.ChartDrawingPart? CreateModelElement(DXPack.ChartDrawingPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ChartDrawingPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.UserShapes = GetUserShapes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.ChartDrawingPart? openXmlElement, DMPack.ChartDrawingPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpUserShapes(openXmlElement, value.UserShapes, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.ChartDrawingPart value)
    where OpenXmlElementType: DXPack.ChartDrawingPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.ChartDrawingPart openXmlElement, DMPack.ChartDrawingPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetImageParts(openXmlElement, value?.ImageParts);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    SetUserShapes(openXmlElement, value?.UserShapes);
  }
}
