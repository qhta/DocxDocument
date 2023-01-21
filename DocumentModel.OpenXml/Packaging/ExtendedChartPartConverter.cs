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
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMDrawsChartDraws.ChartSpace? GetChartSpace(DXPack.ExtendedChartPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXO2016DrawChartDraw.ChartSpace rootElement)
      return DMXDrawsChartDraws.ChartSpaceConverter.CreateModelElement(rootElement);
    return null;
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
  
  private static String? GetContentType(DXPack.ExtendedChartPart openXmlElement)
  {
    return openXmlElement?.ContentType;
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
  
  private static String? GetRelationshipType(DXPack.ExtendedChartPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
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
