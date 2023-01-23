namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResults Class.
/// </summary>
public static class GeoChildEntitiesQueryResultsConverter
{
  private static Collection<DMDrawsChartDraws.GeoChildEntitiesQueryResult> GetItems(DXO2016DrawChartDraw.GeoChildEntitiesQueryResults openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.GeoChildEntitiesQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.GeoChildEntitiesQueryResult>())
    {
      var newItem = DMXDrawsChartDraws.GeoChildEntitiesQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXO2016DrawChartDraw.GeoChildEntitiesQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoChildEntitiesQueryResult>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetItems(DXO2016DrawChartDraw.GeoChildEntitiesQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoChildEntitiesQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.GeoChildEntitiesQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.GeoChildEntitiesQueryResultConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoChildEntitiesQueryResult>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.GeoChildEntitiesQueryResults? CreateModelElement(DXO2016DrawChartDraw.GeoChildEntitiesQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoChildEntitiesQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoChildEntitiesQueryResults? openXmlElement, DMDrawsChartDraws.GeoChildEntitiesQueryResults? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoChildEntitiesQueryResults? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoChildEntitiesQueryResults, new()
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
