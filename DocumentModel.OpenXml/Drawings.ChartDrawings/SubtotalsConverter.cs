namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Subtotals Class.
/// </summary>
public static class SubtotalsConverter
{
  private static Collection<UInt32> GetUnsignedIntegerTypes(DXO2016DrawChartDraw.Subtotals openXmlElement)
  {
    var collection = new Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.UnsignedIntegerType>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    return collection;
  }
  
  private static void SetUnsignedIntegerTypes(DXO2016DrawChartDraw.Subtotals openXmlElement, Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.UnsignedIntegerType>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.UnsignedIntegerType>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.Subtotals? CreateModelElement(DXO2016DrawChartDraw.Subtotals? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Subtotals();
      value.UnsignedIntegerTypes = GetUnsignedIntegerTypes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Subtotals? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Subtotals, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUnsignedIntegerTypes(openXmlElement, value?.UnsignedIntegerTypes);
      return openXmlElement;
    }
    return default;
  }
}
