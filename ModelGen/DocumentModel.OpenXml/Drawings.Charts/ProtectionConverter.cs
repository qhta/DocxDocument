namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Protection Class.
/// </summary>
public static class ProtectionConverter
{
  /// <summary>
  /// Chart Object.
  /// </summary>
  private static Boolean? GetChartObject(DXDrawCharts.Protection openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.ChartObject>() != null;
  }
  
  private static bool CmpChartObject(DXDrawCharts.Protection openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.ChartObject>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.ChartObject", val, value);
    return false;
  }
  
  private static void SetChartObject(DXDrawCharts.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartObject>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.ChartObject();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Cannot Be Changed.
  /// </summary>
  private static Boolean? GetData(DXDrawCharts.Protection openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Data>() != null;
  }
  
  private static bool CmpData(DXDrawCharts.Protection openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Data>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Data", val, value);
    return false;
  }
  
  private static void SetData(DXDrawCharts.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Data>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Data();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Formatting.
  /// </summary>
  private static Boolean? GetFormatting(DXDrawCharts.Protection openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Formatting>() != null;
  }
  
  private static bool CmpFormatting(DXDrawCharts.Protection openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Formatting>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Formatting", val, value);
    return false;
  }
  
  private static void SetFormatting(DXDrawCharts.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Formatting>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Formatting();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Selection.
  /// </summary>
  private static Boolean? GetSelection(DXDrawCharts.Protection openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.Selection>() != null;
  }
  
  private static bool CmpSelection(DXDrawCharts.Protection openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.Selection>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.Selection", val, value);
    return false;
  }
  
  private static void SetSelection(DXDrawCharts.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Selection>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Selection();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// User Interface.
  /// </summary>
  private static Boolean? GetUserInterface(DXDrawCharts.Protection openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawCharts.UserInterface>() != null;
  }
  
  private static bool CmpUserInterface(DXDrawCharts.Protection openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawCharts.UserInterface>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawCharts.UserInterface", val, value);
    return false;
  }
  
  private static void SetUserInterface(DXDrawCharts.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.UserInterface>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.UserInterface();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Protection? CreateModelElement(DXDrawCharts.Protection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Protection();
      value.ChartObject = GetChartObject(openXmlElement);
      value.Data = GetData(openXmlElement);
      value.Formatting = GetFormatting(openXmlElement);
      value.Selection = GetSelection(openXmlElement);
      value.UserInterface = GetUserInterface(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.Protection? openXmlElement, DMDrawsCharts.Protection? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartObject(openXmlElement, value.ChartObject, diffs, objName))
        ok = false;
      if (!CmpData(openXmlElement, value.Data, diffs, objName))
        ok = false;
      if (!CmpFormatting(openXmlElement, value.Formatting, diffs, objName))
        ok = false;
      if (!CmpSelection(openXmlElement, value.Selection, diffs, objName))
        ok = false;
      if (!CmpUserInterface(openXmlElement, value.UserInterface, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Protection value)
    where OpenXmlElementType: DXDrawCharts.Protection, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawCharts.Protection openXmlElement, DMDrawsCharts.Protection value)
  {
    SetChartObject(openXmlElement, value?.ChartObject);
    SetData(openXmlElement, value?.Data);
    SetFormatting(openXmlElement, value?.Formatting);
    SetSelection(openXmlElement, value?.Selection);
    SetUserInterface(openXmlElement, value?.UserInterface);
  }
}
