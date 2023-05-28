namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Protection Class.
/// </summary>
public static class ProtectionConverter
{
  /// <summary>
  /// Chart Object.
  /// </summary>
  private static Boolean? GetChartObject(DXDC.Protection openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.ChartObject>() != null;
  }
  
  private static bool CmpChartObject(DXDC.Protection openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.ChartObject>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.ChartObject", val, value);
    return false;
  }
  
  private static void SetChartObject(DXDC.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.ChartObject>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.ChartObject();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Data Cannot Be Changed.
  /// </summary>
  private static Boolean? GetData(DXDC.Protection openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Data>() != null;
  }
  
  private static bool CmpData(DXDC.Protection openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Data>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Data", val, value);
    return false;
  }
  
  private static void SetData(DXDC.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Data>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Data();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Formatting.
  /// </summary>
  private static Boolean? GetFormatting(DXDC.Protection openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Formatting>() != null;
  }
  
  private static bool CmpFormatting(DXDC.Protection openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Formatting>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Formatting", val, value);
    return false;
  }
  
  private static void SetFormatting(DXDC.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Formatting>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Formatting();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Selection.
  /// </summary>
  private static Boolean? GetSelection(DXDC.Protection openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Selection>() != null;
  }
  
  private static bool CmpSelection(DXDC.Protection openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Selection>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Selection", val, value);
    return false;
  }
  
  private static void SetSelection(DXDC.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Selection>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Selection();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// User Interface.
  /// </summary>
  private static Boolean? GetUserInterface(DXDC.Protection openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.UserInterface>() != null;
  }
  
  private static bool CmpUserInterface(DXDC.Protection openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDC.UserInterface>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.UserInterface", val, value);
    return false;
  }
  
  private static void SetUserInterface(DXDC.Protection openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.UserInterface>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.UserInterface();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.Protection? CreateModelElement(DXDC.Protection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.Protection();
      value.ChartObject = GetChartObject(openXmlElement);
      value.Data = GetData(openXmlElement);
      value.Formatting = GetFormatting(openXmlElement);
      value.Selection = GetSelection(openXmlElement);
      value.UserInterface = GetUserInterface(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.Protection? openXmlElement, DMDC.Protection? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChartObject(openXmlElement, value.ChartObject, diffs, objName, propName))
        ok = false;
      if (!CmpData(openXmlElement, value.Data, diffs, objName, propName))
        ok = false;
      if (!CmpFormatting(openXmlElement, value.Formatting, diffs, objName, propName))
        ok = false;
      if (!CmpSelection(openXmlElement, value.Selection, diffs, objName, propName))
        ok = false;
      if (!CmpUserInterface(openXmlElement, value.UserInterface, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.Protection value)
    where OpenXmlElementType: DXDC.Protection, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.Protection openXmlElement, DMDC.Protection value)
  {
    SetChartObject(openXmlElement, value?.ChartObject);
    SetData(openXmlElement, value?.Data);
    SetFormatting(openXmlElement, value?.Formatting);
    SetSelection(openXmlElement, value?.Selection);
    SetUserInterface(openXmlElement, value?.UserInterface);
  }
}
