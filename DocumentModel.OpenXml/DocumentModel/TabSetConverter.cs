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
