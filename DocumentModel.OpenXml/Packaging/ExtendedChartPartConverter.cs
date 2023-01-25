namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ExtendedChartPart
/// </summary>
public static class ExtendedChartPartConverter
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  private static Collection<DMPack.ChartColorStylePart> GetChartColorStyleParts(DXPack.ExtendedChartPart openXmlElement)
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
  
  private static bool CmpChartColorStyleParts(DXPack.ExtendedChartPart openXmlElement, Collection<DMPack.ChartColorStylePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsChartDraws.ChartSpace? GetChartSpace(DXPack.ExtendedChartPart openXmlElement)
  {
      return DMXDrawsChartDraws.ChartSpaceConverter.CreateModelElement(openXmlElement?.RootElement as DXO2016DrawChartDraw.ChartSpace);
  }
  
  private static bool CmpChartSpace(DXPack.ExtendedChartPart openXmlElement, DMDrawsChartDraws.ChartSpace? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetChartSpace(DXPack.ExtendedChartPart openXmlElement, DMDrawsChartDraws.ChartSpace? value)
  {
    if (value != null)
    {
       var rootElement = DMXDrawsChartDraws.ChartSpaceConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ChartSpace>(value);
       if (rootElement != null)
         openXmlElement.ChartSpace = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ExtendedChartPart
  /// </summary>
  private static Collection<DMPack.ChartStylePart> GetChartStyleParts(DXPack.ExtendedChartPart openXmlElement)
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
  
  private static bool CmpChartStyleParts(DXPack.ExtendedChartPart openXmlElement, Collection<DMPack.ChartStylePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetContentType(DXPack.ExtendedChartPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.ExtendedChartPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ExtendedChartPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.ExtendedChartPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.ExtendedChartPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.ExtendedChartPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.ExtendedChartPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.ExtendedChartPart? CreateModelElement(DXPack.ExtendedChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ExtendedChartPart();
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
  
  public static bool CompareModelElement(DXPack.ExtendedChartPart? openXmlElement, DMPack.ExtendedChartPart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ExtendedChartPart? value)
    where OpenXmlElementType: DXPack.ExtendedChartPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetChartColorStyleParts(openXmlElement, value?.ChartColorStyleParts);
      SetChartSpace(openXmlElement, value?.ChartSpace);
      //SetChartStyleParts(openXmlElement, value?.ChartStyleParts);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
