namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoLocationQueryResults Class.
/// </summary>
public static class GeoLocationQueryResultsConverter
{
  private static Collection<DMDrawsChartDraws.GeoLocationQueryResult> GetItems(DXO2016DrawChartDraw.GeoLocationQueryResults openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.GeoLocationQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.GeoLocationQueryResult>())
    {
      var newItem = DMXDrawsChartDraws.GeoLocationQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXO2016DrawChartDraw.GeoLocationQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoLocationQueryResult>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetItems(DXO2016DrawChartDraw.GeoLocationQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoLocationQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.GeoLocationQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.GeoLocationQueryResultConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoLocationQueryResult>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.GeoLocationQueryResults? CreateModelElement(DXO2016DrawChartDraw.GeoLocationQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoLocationQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoLocationQueryResults? openXmlElement, DMDrawsChartDraws.GeoLocationQueryResults? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoLocationQueryResults? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoLocationQueryResults, new()
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
