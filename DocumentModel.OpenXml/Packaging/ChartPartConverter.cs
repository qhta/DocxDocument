namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartPart
/// </summary>
public static class ChartPartConverter
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  private static Collection<DMPack.ChartColorStylePart>? GetChartColorStyleParts(DXPack.ChartPart openXmlElement)
  {
    var collection = new Collection<DMPack.ChartColorStylePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.ChartColorStylePart>())
    {
      var newItem = DMXPack.ChartColorStylePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpChartColorStyleParts(DXPack.ChartPart openXmlElement, Collection<DMPack.ChartColorStylePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsCharts.ChartSpace? GetChartSpace(DXPack.ChartPart openXmlElement)
  {
      return DMXDrawsCharts.ChartSpaceConverter.CreateModelElement(openXmlElement?.RootElement as DXDrawCharts.ChartSpace);
  }
  
  private static bool CmpChartSpace(DXPack.ChartPart openXmlElement, DMDrawsCharts.ChartSpace? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetChartSpace(DXPack.ChartPart openXmlElement, DMDrawsCharts.ChartSpace? value)
  {
    if (value != null)
    {
       var rootElement = DMXDrawsCharts.ChartSpaceConverter.CreateOpenXmlElement<DXDrawCharts.ChartSpace>(value);
       if (rootElement != null)
         openXmlElement.ChartSpace = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ChartPart
  /// </summary>
  private static Collection<DMPack.ChartStylePart>? GetChartStyleParts(DXPack.ChartPart openXmlElement)
  {
    var collection = new Collection<DMPack.ChartStylePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.ChartStylePart>())
    {
      var newItem = DMXPack.ChartStylePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpChartStyleParts(DXPack.ChartPart openXmlElement, Collection<DMPack.ChartStylePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetContentType(DXPack.ChartPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.ChartPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ChartPart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.ChartPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.ChartPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.ChartPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.ChartPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.ChartPart? CreateModelElement(DXPack.ChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ChartPart();
      value.ChartColorStyleParts = GetChartColorStyleParts(openXmlElement);
      value.ChartSpace = GetChartSpace(openXmlElement);
      value.ChartStyleParts = GetChartStyleParts(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.ChartPart? openXmlElement, DMPack.ChartPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartColorStyleParts(openXmlElement, value.ChartColorStyleParts, diffs, objName))
        ok = false;
      if (!CmpChartSpace(openXmlElement, value.ChartSpace, diffs, objName))
        ok = false;
      if (!CmpChartStyleParts(openXmlElement, value.ChartStyleParts, diffs, objName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.ChartPart value)
    where OpenXmlElementType: DXPack.ChartPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.ChartPart openXmlElement, DMPack.ChartPart value)
  {
    //SetChartColorStyleParts(openXmlElement, value?.ChartColorStyleParts);
    SetChartSpace(openXmlElement, value?.ChartSpace);
    //SetChartStyleParts(openXmlElement, value?.ChartStyleParts);
    //SetContentType(openXmlElement, value?.ContentType);
    //SetImageParts(openXmlElement, value?.ImageParts);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
