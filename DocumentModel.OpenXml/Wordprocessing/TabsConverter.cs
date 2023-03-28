namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Tabs Class converter from/to OpenXml.
///</summary>
public static class TabsConverter
{
  private static DMW.TabStop? GetTabStop(DXW.TabStop? openXmlElement)
  {
    if (openXmlElement != null)
      return DMXW.TabStopConverter.CreateModelElement(openXmlElement);
    return null;
  }

  private static bool CmpTabStop(DXW.TabStop openXmlElement, DMW.TabStop? value, DiffList? diffs, string? objName, string? propName)
  {
    return DMXW.TabStopConverter.CompareModelElement(openXmlElement, value, diffs, objName, propName);
  }

  //private static void SetTabStop(DXW.TabStop openXmlElement, DMW.TabStop? value)
  //{
  //    itemElement = DMXW.TabStopConverter.CreateOpenXmlElement<DXW.TabStop>(value);
  //    if (itemElement != null)
  //      openXmlElement.AddChild(itemElement);
  //  }
  //}

  public static DMW.Tabs? CreateModelElement(DXW.Tabs? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Tabs();
      foreach (var element in openXmlElement.Elements<DXW.TabStop>())
      {
        var tabStop = GetTabStop(element);
        if (tabStop != null)
          value.Add(tabStop);
      }
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Tabs? openXmlElement, DMW.Tabs? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      var openXmlTabStops = openXmlElement.Elements<DXW.TabStop>().ToArray();
      var modelTabStops = value.ToArray();
      for (int i = 0; i < System.Math.Min(openXmlTabStops.Length, modelTabStops.Length); i++)
        if (!CmpTabStop(openXmlTabStops[i], modelTabStops[i], diffs, objName, $"[{i}]"))
          ok = false;
      if (!Int32ValueConverter.CmpValue(openXmlTabStops.Length, modelTabStops.Length, diffs, objName, "Count"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Tabs value)
    where OpenXmlElementType : DXW.Tabs, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.Tabs openXmlElement, DMW.Tabs value)
  {

  }
}
