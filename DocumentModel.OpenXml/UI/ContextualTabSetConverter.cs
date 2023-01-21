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
    return openXmlElement?.IdMso?.Value;
  }
  
  private static void SetIdMso(DXOCustUI.ContextualTabSet openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.ContextualTabSet openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
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
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DXOCustUI.ContextualTabSet openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  private static Collection<DMUI.Tab> GetTabs(DXOCustUI.ContextualTabSet openXmlElement)
  {
    var collection = new Collection<DMUI.Tab>();
    foreach (var item in openXmlElement.Elements<DXOCustUI.Tab>())
    {
      var newItem = DMXUI.TabConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
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
  
  public static DMUI.ContextualTabSet? CreateModelElement(DXOCustUI.ContextualTabSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.ContextualTabSet();
      value.IdMso = GetIdMso(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.ContextualTabSet? value)
    where OpenXmlElementType: DXOCustUI.ContextualTabSet, new()
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
