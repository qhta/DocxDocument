namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataEntityQueryResults Class.
/// </summary>
public static class GeoDataEntityQueryResultsConverter
{
  private static Collection<DMDrawsChartDraws.GeoDataEntityQueryResult> GetItems(DXO2016DrawChartDraw.GeoDataEntityQueryResults openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.GeoDataEntityQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.GeoDataEntityQueryResult>())
    {
      var newItem = DMXDrawsChartDraws.GeoDataEntityQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetItems(DXO2016DrawChartDraw.GeoDataEntityQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoDataEntityQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.GeoDataEntityQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.GeoDataEntityQueryResultConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoDataEntityQueryResult>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.GeoDataEntityQueryResults? CreateModelElement(DXO2016DrawChartDraw.GeoDataEntityQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoDataEntityQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoDataEntityQueryResults? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoDataEntityQueryResults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
