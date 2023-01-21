namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartPart
/// </summary>
public static class ChartPartConverter
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  private static Collection<DMPack.ChartColorStylePart> GetChartColorStyleParts(DXPack.ChartPart openXmlElement)
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
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsCharts.ChartSpace? GetChartSpace(DXPack.ChartPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXDrawCharts.ChartSpace rootElement)
      return DMXDrawsCharts.ChartSpaceConverter.CreateModelElement(rootElement);
    return null;
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
  private static Collection<DMPack.ChartStylePart> GetChartStyleParts(DXPack.ChartPart openXmlElement)
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
  
  private static String? GetContentType(DXPack.ChartPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ChartPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.ChartPart openXmlElement)
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
  
  private static String? GetRelationshipType(DXPack.ChartPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.ChartPart? CreateModelElement(DXPack.ChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ChartPart();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ChartPart? value)
    where OpenXmlElementType: DXPack.ChartPart, new()
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
