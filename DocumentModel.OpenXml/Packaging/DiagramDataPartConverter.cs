namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramDataPart
/// </summary>
public static class DiagramDataPartConverter
{
  private static String? GetContentType(DXPack.DiagramDataPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.DiagramDataPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDD.DataModelRoot? GetDataModelRoot(DXPack.DiagramDataPart openXmlElement)
  {
      return DMXDD.DataModelRootConverter.CreateModelElement(openXmlElement?.RootElement as DXDD.DataModelRoot);
  }
  
  private static bool CmpDataModelRoot(DXPack.DiagramDataPart openXmlElement, DMDD.DataModelRoot? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetDataModelRoot(DXPack.DiagramDataPart openXmlElement, DMDD.DataModelRoot? value)
  {
    if (value != null)
    {
       var rootElement = DMXDD.DataModelRootConverter.CreateOpenXmlElement<DXDD.DataModelRoot>(value);
       if (rootElement != null)
         openXmlElement.DataModelRoot = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramDataPart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.DiagramDataPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.DiagramDataPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.DiagramDataPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.DiagramDataPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the SlideParts of the DiagramDataPart
  /// </summary>
  private static Collection<DMPack.SlidePart>? GetSlideParts(DXPack.DiagramDataPart openXmlElement)
  {
    var collection = new Collection<DMPack.SlidePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.SlidePart>())
    {
      var newItem = DMXPack.SlidePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpSlideParts(DXPack.DiagramDataPart openXmlElement, Collection<DMPack.SlidePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  private static Collection<DMPack.WorksheetPart>? GetWorksheetParts(DXPack.DiagramDataPart openXmlElement)
  {
    var collection = new Collection<DMPack.WorksheetPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.WorksheetPart>())
    {
      var newItem = DMXPack.WorksheetPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpWorksheetParts(DXPack.DiagramDataPart openXmlElement, Collection<DMPack.WorksheetPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  public static DocumentModel.Packaging.DiagramDataPart? CreateModelElement(DXPack.DiagramDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.DataModelRoot = GetDataModelRoot(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.SlideParts = GetSlideParts(openXmlElement);
      value.WorksheetParts = GetWorksheetParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.DiagramDataPart? openXmlElement, DMPack.DiagramDataPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpDataModelRoot(openXmlElement, value.DataModelRoot, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpSlideParts(openXmlElement, value.SlideParts, diffs, objName))
        ok = false;
      if (!CmpWorksheetParts(openXmlElement, value.WorksheetParts, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.DiagramDataPart value)
    where OpenXmlElementType: DXPack.DiagramDataPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.DiagramDataPart openXmlElement, DMPack.DiagramDataPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    SetDataModelRoot(openXmlElement, value?.DataModelRoot);
    //SetImageParts(openXmlElement, value?.ImageParts);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    //SetSlideParts(openXmlElement, value?.SlideParts);
    //SetWorksheetParts(openXmlElement, value?.WorksheetParts);
  }
}
