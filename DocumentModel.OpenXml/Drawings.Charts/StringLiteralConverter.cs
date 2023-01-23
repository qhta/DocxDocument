namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// String Literal.
/// </summary>
public static class StringLiteralConverter
{
  private static UInt32? GetPointCount(DXDrawCharts.StringLiteral openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val?.Value;
  }
  
  private static bool CmpPointCount(DXDrawCharts.StringLiteral openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawCharts.PointCount>()?.Val?.Value == value;
  }
  
  private static void SetPointCount(DXDrawCharts.StringLiteral openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PointCount>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.PointCount{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsCharts.StringPoint> GetStringPoints(DXDrawCharts.StringLiteral openXmlElement)
  {
    var collection = new Collection<DMDrawsCharts.StringPoint>();
    foreach (var item in openXmlElement.Elements<DXDrawCharts.StringPoint>())
    {
      var newItem = DMXDrawsCharts.StringPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpStringPoints(DXDrawCharts.StringLiteral openXmlElement, Collection<DMDrawsCharts.StringPoint>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetStringPoints(DXDrawCharts.StringLiteral openXmlElement, Collection<DMDrawsCharts.StringPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DXDrawCharts.StringPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsCharts.StringPointConverter.CreateOpenXmlElement<DXDrawCharts.StringPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsCharts.StrDataExtensionList? GetStrDataExtensionList(DXDrawCharts.StringLiteral openXmlElement)
  {
    return DMXDrawsCharts.StrDataExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.StrDataExtensionList>());
  }
  
  private static bool CmpStrDataExtensionList(DXDrawCharts.StringLiteral openXmlElement, DMDrawsCharts.StrDataExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.StrDataExtensionListConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDrawCharts.StrDataExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStrDataExtensionList(DXDrawCharts.StringLiteral openXmlElement, DMDrawsCharts.StrDataExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StrDataExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StrDataExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.StrDataExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.StringLiteral? CreateModelElement(DXDrawCharts.StringLiteral? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.StringLiteral();
      value.PointCount = GetPointCount(openXmlElement);
      value.StringPoints = GetStringPoints(openXmlElement);
      value.StrDataExtensionList = GetStrDataExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.StringLiteral? openXmlElement, DMDrawsCharts.StringLiteral? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPointCount(openXmlElement, value.PointCount, diffs, objName))
        ok = false;
      if (!CmpStringPoints(openXmlElement, value.StringPoints, diffs, objName))
        ok = false;
      if (!CmpStrDataExtensionList(openXmlElement, value.StrDataExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.StringLiteral? value)
    where OpenXmlElementType: DXDrawCharts.StringLiteral, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPointCount(openXmlElement, value?.PointCount);
      SetStringPoints(openXmlElement, value?.StringPoints);
      SetStrDataExtensionList(openXmlElement, value?.StrDataExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
