namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Custom Split.
/// </summary>
public static class CustomSplitConverter
{
  private static Collection<UInt32> GetSecondPiePoints(DXDrawCharts.CustomSplit openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.SecondPiePoint>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    return collection;
  }
  
  private static void SetSecondPiePoints(DXDrawCharts.CustomSplit openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.SecondPiePoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXDrawCharts.SecondPiePoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsCharts.CustomSplit? CreateModelElement(DXDrawCharts.CustomSplit? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.CustomSplit();
      value.SecondPiePoints = GetSecondPiePoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.CustomSplit? value)
    where OpenXmlElementType: DXDrawCharts.CustomSplit, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSecondPiePoints(openXmlElement, value?.SecondPiePoints);
      return openXmlElement;
    }
    return default;
  }
}
