namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ExtendedChartPart
/// </summary>
public static class ExtendedChartPartConverter
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  private static Collection<DMPack.ChartColorStylePart>? GetChartColorStyleParts(DXPack.ExtendedChartPart openXmlElement)
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
  
  private static bool CmpChartColorStyleParts(DXPack.ExtendedChartPart openXmlElement, Collection<DMPack.ChartColorStylePart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDCDs.ChartSpace? GetChartSpace(DXPack.ExtendedChartPart openXmlElement)
  {
      return DMXDCDs.ChartSpaceConverter.CreateModelElement(openXmlElement?.RootElement as DXO16DCD.ChartSpace);
  }
  
  private static bool CmpChartSpace(DXPack.ExtendedChartPart openXmlElement, DMDCDs.ChartSpace? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetChartSpace(DXPack.ExtendedChartPart openXmlElement, DMDCDs.ChartSpace? value)
  {
    if (value != null)
    {
       var rootElement = DMXDCDs.ChartSpaceConverter.CreateOpenXmlElement<DXO16DCD.ChartSpace>(value);
       if (rootElement != null)
         openXmlElement.ChartSpace = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ExtendedChartPart
  /// </summary>
  private static Collection<DMPack.ChartStylePart>? GetChartStyleParts(DXPack.ExtendedChartPart openXmlElement)
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
  
  private static bool CmpChartStyleParts(DXPack.ExtendedChartPart openXmlElement, Collection<DMPack.ChartStylePart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  private static String? GetContentType(DXPack.ExtendedChartPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.ExtendedChartPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ExtendedChartPart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.ExtendedChartPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.ExtendedChartPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.ExtendedChartPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.ExtendedChartPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.ExtendedChartPart? CreateModelElement(DXPack.ExtendedChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ExtendedChartPart();
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
  
  public static bool CompareModelElement(DXPack.ExtendedChartPart? openXmlElement, DMPack.ExtendedChartPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartColorStyleParts(openXmlElement, value.ChartColorStyleParts, diffs, objName, propName))
        ok = false;
      if (!CmpChartSpace(openXmlElement, value.ChartSpace, diffs, objName, propName))
        ok = false;
      if (!CmpChartStyleParts(openXmlElement, value.ChartStyleParts, diffs, objName, propName))
        ok = false;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.ExtendedChartPart value)
    where OpenXmlElementType: DXPack.ExtendedChartPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.ExtendedChartPart openXmlElement, DMPack.ExtendedChartPart value)
  {
    //SetChartColorStyleParts(openXmlElement, value?.ChartColorStyleParts);
    SetChartSpace(openXmlElement, value?.ChartSpace);
    //SetChartStyleParts(openXmlElement, value?.ChartStyleParts);
    //SetContentType(openXmlElement, value?.ContentType);
    //SetImageParts(openXmlElement, value?.ImageParts);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
