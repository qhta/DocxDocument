namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public static class DisplayUnitsConverter
{
  private static Double? GetCustomDisplayUnit(DXDrawCharts.DisplayUnits openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.CustomDisplayUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetCustomDisplayUnit(DXDrawCharts.DisplayUnits openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.CustomDisplayUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.CustomDisplayUnit{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.BuiltInUnitKind? GetBuiltInUnit(DXDrawCharts.DisplayUnits openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BuiltInUnit>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDrawsCharts.BuiltInUnitKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetBuiltInUnit(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.BuiltInUnitKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.BuiltInUnit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawCharts.BuiltInUnit, DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DMDrawsCharts.BuiltInUnitKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.DisplayUnitsLabel? GetDisplayUnitsLabel(DXDrawCharts.DisplayUnits openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.DisplayUnitsLabel>();
    if (itemElement != null)
      return DMXDrawsCharts.DisplayUnitsLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDisplayUnitsLabel(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.DisplayUnitsLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.DisplayUnitsLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DisplayUnitsLabelConverter.CreateOpenXmlElement<DXDrawCharts.DisplayUnitsLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ExtensionList? GetExtensionList(DXDrawCharts.DisplayUnits openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXDrawCharts.DisplayUnits openXmlElement, DMDrawsCharts.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.DisplayUnits? CreateModelElement(DXDrawCharts.DisplayUnits? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DisplayUnits();
      value.CustomDisplayUnit = GetCustomDisplayUnit(openXmlElement);
      value.BuiltInUnit = GetBuiltInUnit(openXmlElement);
      value.DisplayUnitsLabel = GetDisplayUnitsLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DisplayUnits? value)
    where OpenXmlElementType: DXDrawCharts.DisplayUnits, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomDisplayUnit(openXmlElement, value?.CustomDisplayUnit);
      SetBuiltInUnit(openXmlElement, value?.BuiltInUnit);
      SetDisplayUnitsLabel(openXmlElement, value?.DisplayUnitsLabel);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
