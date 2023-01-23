namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TabSet Class.
/// </summary>
public static class TabSetConverter
{
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.TabSet openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXO2010CustUI.TabSet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.IdMso?.Value == value;
  }
  
  private static void SetIdMso(DXO2010CustUI.TabSet openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.TabSet openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.TabSet openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Visible?.Value == value;
  }
  
  private static void SetVisible(DXO2010CustUI.TabSet openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.TabSet openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.TabSet openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetVisible?.Value == value;
  }
  
  private static void SetGetVisible(DXO2010CustUI.TabSet openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  private static Collection<DM.Tab> GetTabs(DXO2010CustUI.TabSet openXmlElement)
  {
    var collection = new Collection<DM.Tab>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.Tab>())
    {
      var newItem = DMX.TabConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpTabs(DXO2010CustUI.TabSet openXmlElement, Collection<DM.Tab>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetTabs(DXO2010CustUI.TabSet openXmlElement, Collection<DM.Tab>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010CustUI.Tab>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.TabConverter.CreateOpenXmlElement<DXO2010CustUI.Tab>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DM.TabSet? CreateModelElement(DXO2010CustUI.TabSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.TabSet();
      value.IdMso = GetIdMso(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.TabSet? openXmlElement, DM.TabSet? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.TabSet? value)
    where OpenXmlElementType: DXO2010CustUI.TabSet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIdMso(openXmlElement, value?.IdMso);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetTabs(openXmlElement, value?.Tabs);
      return openXmlElement;
    }
    return default;
  }
}
