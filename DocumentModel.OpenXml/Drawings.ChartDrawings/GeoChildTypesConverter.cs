namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildTypes Class.
/// </summary>
public static class GeoChildTypesConverter
{
  private static Collection<String> GetEntityTypes(DXO2016DrawChartDraw.GeoChildTypes openXmlElement)
  {
    var collection = new Collection<String>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.EntityType>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((string)newItem);
    }
    return collection;
  }
  
  private static void SetEntityTypes(DXO2016DrawChartDraw.GeoChildTypes openXmlElement, Collection<String>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.EntityType>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = StringValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.EntityType>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.GeoChildTypes? CreateModelElement(DXO2016DrawChartDraw.GeoChildTypes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoChildTypes();
      value.EntityTypes = GetEntityTypes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoChildTypes? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoChildTypes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEntityTypes(openXmlElement, value?.EntityTypes);
      return openXmlElement;
    }
    return default;
  }
}
