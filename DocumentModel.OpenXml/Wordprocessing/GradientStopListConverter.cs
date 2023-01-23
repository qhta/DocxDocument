namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the GradientStopList Class.
/// </summary>
public static class GradientStopListConverter
{
  private static Collection<DMW.GradientStop> GetGradientStops(DXO2010W.GradientStopList openXmlElement)
  {
    var collection = new Collection<DMW.GradientStop>();
    foreach (var item in openXmlElement.Elements<DXO2010W.GradientStop>())
    {
      var newItem = DMXW.GradientStopConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpGradientStops(DXO2010W.GradientStopList openXmlElement, Collection<DMW.GradientStop>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetGradientStops(DXO2010W.GradientStopList openXmlElement, Collection<DMW.GradientStop>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010W.GradientStop>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXW.GradientStopConverter.CreateOpenXmlElement<DXO2010W.GradientStop>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMW.GradientStopList? CreateModelElement(DXO2010W.GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.GradientStopList();
      value.GradientStops = GetGradientStops(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.GradientStopList? openXmlElement, DMW.GradientStopList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpGradientStops(openXmlElement, value.GradientStops, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.GradientStopList? value)
    where OpenXmlElementType: DXO2010W.GradientStopList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGradientStops(openXmlElement, value?.GradientStops);
      return openXmlElement;
    }
    return default;
  }
}
