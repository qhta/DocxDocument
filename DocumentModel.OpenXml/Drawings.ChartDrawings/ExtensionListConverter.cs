namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  private static Collection<DMDrawsChartDraws.Extension2> GetExtension2s(DXO2016DrawChartDraw.ExtensionList openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.Extension2>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.Extension2>())
    {
      var newItem = DMXDrawsChartDraws.Extension2Converter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpExtension2s(DXO2016DrawChartDraw.ExtensionList openXmlElement, Collection<DMDrawsChartDraws.Extension2>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetExtension2s(DXO2016DrawChartDraw.ExtensionList openXmlElement, Collection<DMDrawsChartDraws.Extension2>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.Extension2>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.Extension2Converter.CreateOpenXmlElement<DXO2016DrawChartDraw.Extension2>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDrawsChartDraws.ExtensionList? CreateModelElement(DXO2016DrawChartDraw.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ExtensionList();
      value.Extension2s = GetExtension2s(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.ExtensionList? openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtension2s(openXmlElement, value.Extension2s, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ExtensionList? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension2s(openXmlElement, value?.Extension2s);
      return openXmlElement;
    }
    return default;
  }
}
