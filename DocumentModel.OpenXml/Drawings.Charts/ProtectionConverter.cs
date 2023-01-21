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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartObject>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Data>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Formatting>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Selection>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.UserInterface>();
    return itemElement != null;
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
  
  public static DMDrawsCharts.Protection? CreateModelElement(DXDrawCharts.Protection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.Protection();
      value.ChartObject = GetChartObject(openXmlElement);
      value.Data = GetData(openXmlElement);
      value.Formatting = GetFormatting(openXmlElement);
      value.Selection = GetSelection(openXmlElement);
      value.UserInterface = GetUserInterface(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.Protection? value)
    where OpenXmlElementType: DXDrawCharts.Protection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartObject(openXmlElement, value?.ChartObject);
      SetData(openXmlElement, value?.Data);
      SetFormatting(openXmlElement, value?.Formatting);
      SetSelection(openXmlElement, value?.Selection);
      SetUserInterface(openXmlElement, value?.UserInterface);
      return openXmlElement;
    }
    return default;
  }
}
