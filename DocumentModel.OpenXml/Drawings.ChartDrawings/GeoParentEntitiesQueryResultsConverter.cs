namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResults Class.
/// </summary>
public static class GeoParentEntitiesQueryResultsConverter
{
  private static Collection<DMDrawsChartDraws.GeoParentEntitiesQueryResult> GetItems(DXO2016DrawChartDraw.GeoParentEntitiesQueryResults openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.GeoParentEntitiesQueryResult>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.GeoParentEntitiesQueryResult>())
    {
      var newItem = DMXDrawsChartDraws.GeoParentEntitiesQueryResultConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXO2016DrawChartDraw.GeoParentEntitiesQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoParentEntitiesQueryResult>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetItems(DXO2016DrawChartDraw.GeoParentEntitiesQueryResults openXmlElement, Collection<DMDrawsChartDraws.GeoParentEntitiesQueryResult>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.GeoParentEntitiesQueryResult>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.GeoParentEntitiesQueryResultConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.GeoParentEntitiesQueryResult>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.GeoParentEntitiesQueryResults? CreateModelElement(DXO2016DrawChartDraw.GeoParentEntitiesQueryResults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.GeoParentEntitiesQueryResults();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.GeoParentEntitiesQueryResults? openXmlElement, DMDrawsChartDraws.GeoParentEntitiesQueryResults? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.GeoParentEntitiesQueryResults? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.GeoParentEntitiesQueryResults, new()
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
