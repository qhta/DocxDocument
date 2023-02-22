namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the ContextualTabSet Class.
/// </summary>
public static class ContextualTabSetConverter
{
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.ContextualTabSet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXOCustUI.ContextualTabSet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXOCustUI.ContextualTabSet openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.ContextualTabSet openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.ContextualTabSet openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCustUI.ContextualTabSet openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.ContextualTabSet openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXOCustUI.ContextualTabSet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXOCustUI.ContextualTabSet openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  private static Collection<DMUI.Tab>? GetTabs(DXOCustUI.ContextualTabSet openXmlElement)
  {
    var collection = new Collection<DMUI.Tab>();
    foreach (var item in openXmlElement.Elements<DXOCustUI.Tab>())
    {
      var newItem = DMXUI.TabConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpTabs(DXOCustUI.ContextualTabSet openXmlElement, Collection<DMUI.Tab>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXOCustUI.Tab>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXUI.TabConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetTabs(DXOCustUI.ContextualTabSet openXmlElement, Collection<DMUI.Tab>? value)
  {
    openXmlElement.RemoveAllChildren<DXOCustUI.Tab>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXUI.TabConverter.CreateOpenXmlElement<DXOCustUI.Tab>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.UI.ContextualTabSet? CreateModelElement(DXOCustUI.ContextualTabSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.ContextualTabSet();
      value.IdMso = GetIdMso(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.ContextualTabSet? openXmlElement, DMUI.ContextualTabSet? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpTabs(openXmlElement, value.Tabs, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.ContextualTabSet value)
    where OpenXmlElementType: DXOCustUI.ContextualTabSet, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.ContextualTabSet openXmlElement, DMUI.ContextualTabSet value)
  {
    SetIdMso(openXmlElement, value?.IdMso);
    SetVisible(openXmlElement, value?.Visible);
    SetGetVisible(openXmlElement, value?.GetVisible);
    SetTabs(openXmlElement, value?.Tabs);
  }
}
