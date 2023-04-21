namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Legend Entry.
/// </summary>
public static class LegendEntryConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  private static UInt32? GetIndex(DXDC.LegendEntry openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val);
  }
  
  private static bool CmpIndex(DXDC.LegendEntry openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDC.Index>()?.Val, value, diffs, objName, "Index");
  }
  
  private static void SetIndex(DXDC.LegendEntry openXmlElement, UInt32? value)
  {
    SimpleValueConverter.SetValue<DXDC.Index,System.UInt32>(openXmlElement, value);
  }
  
  private static Boolean? GetDelete(DXDC.LegendEntry openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDC.Delete>() != null;
  }
  
  private static bool CmpDelete(DXDC.LegendEntry openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDC.Delete>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDC.Delete", val, value);
    return false;
  }
  
  private static void SetDelete(DXDC.LegendEntry openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDC.Delete>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDC.Delete();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDC.TextProperties? GetTextProperties(DXDC.LegendEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.TextProperties>();
    if (element != null)
      return DMXDC.TextPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextProperties(DXDC.LegendEntry openXmlElement, DMDC.TextProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDC.TextPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.TextProperties>(), value, diffs, objName);
  }
  
  private static void SetTextProperties(DXDC.LegendEntry openXmlElement, DMDC.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.TextPropertiesConverter.CreateOpenXmlElement<DXDC.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDC.ExtensionList? GetExtensionList(DXDC.LegendEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.ExtensionList>();
    if (element != null)
      return DMXDC.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDC.LegendEntry openXmlElement, DMDC.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDC.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXDC.LegendEntry openXmlElement, DMDC.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.LegendEntry? CreateModelElement(DXDC.LegendEntry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LegendEntry();
      value.Index = GetIndex(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.LegendEntry? openXmlElement, DMDC.LegendEntry? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName))
        ok = false;
      if (!CmpDelete(openXmlElement, value.Delete, diffs, objName))
        ok = false;
      if (!CmpTextProperties(openXmlElement, value.TextProperties, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.LegendEntry value)
    where OpenXmlElementType: DXDC.LegendEntry, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.LegendEntry openXmlElement, DMDC.LegendEntry value)
  {
    SetIndex(openXmlElement, value?.Index);
    SetDelete(openXmlElement, value?.Delete);
    SetTextProperties(openXmlElement, value?.TextProperties);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
