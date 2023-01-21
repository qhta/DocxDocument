namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Chart Space.
/// </summary>
public static class ChartSpaceConverter
{
  /// <summary>
  /// Date1904.
  /// </summary>
  private static Boolean? GetDate1904(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Date1904>();
    return itemElement != null;
  }
  
  private static void SetDate1904(DXDrawCharts.ChartSpace openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Date1904>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.Date1904();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// EditingLanguage.
  /// </summary>
  private static String? GetEditingLanguage(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.EditingLanguage>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetEditingLanguage(DXDrawCharts.ChartSpace openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.EditingLanguage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.EditingLanguage { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RoundedCorners.
  /// </summary>
  private static Boolean? GetRoundedCorners(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RoundedCorners>();
    return itemElement != null;
  }
  
  private static void SetRoundedCorners(DXDrawCharts.ChartSpace openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RoundedCorners>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawCharts.RoundedCorners();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Byte? GetStyle(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010DrawCharts.Style>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetStyle(DXDrawCharts.ChartSpace openXmlElement, Byte? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010DrawCharts.Style{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ColorMapOverride? GetColorMapOverride(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ColorMapOverride>();
    if (itemElement != null)
      return DMXDrawsCharts.ColorMapOverrideConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetColorMapOverride(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ColorMapOverride? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ColorMapOverride>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ColorMapOverrideConverter.CreateOpenXmlElement<DXDrawCharts.ColorMapOverride>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.PivotSource? GetPivotSource(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PivotSource>();
    if (itemElement != null)
      return DMXDrawsCharts.PivotSourceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPivotSource(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.PivotSource? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PivotSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PivotSourceConverter.CreateOpenXmlElement<DXDrawCharts.PivotSource>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Protection? GetProtection(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Protection>();
    if (itemElement != null)
      return DMXDrawsCharts.ProtectionConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetProtection(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.Protection? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Protection>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ProtectionConverter.CreateOpenXmlElement<DXDrawCharts.Protection>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Chart? GetChart(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.Chart>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChart(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.Chart? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.Chart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartConverter.CreateOpenXmlElement<DXDrawCharts.Chart>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ShapeProperties? GetShapeProperties(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ShapePropertiesConverter.CreateOpenXmlElement<DXDrawCharts.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.TextProperties? GetTextProperties(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.TextProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextProperties(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.TextProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.TextProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.TextPropertiesConverter.CreateOpenXmlElement<DXDrawCharts.TextProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ExternalData? GetExternalData(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ExternalData>();
    if (itemElement != null)
      return DMXDrawsCharts.ExternalDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExternalData(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ExternalData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ExternalData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ExternalDataConverter.CreateOpenXmlElement<DXDrawCharts.ExternalData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.PrintSettings? GetPrintSettings(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.PrintSettings>();
    if (itemElement != null)
      return DMXDrawsCharts.PrintSettingsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPrintSettings(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.PrintSettings? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.PrintSettings>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.PrintSettingsConverter.CreateOpenXmlElement<DXDrawCharts.PrintSettings>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.RelationshipIdType? GetUserShapesReference(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.UserShapesReference>();
    if (itemElement != null)
      return DMXDrawsCharts.RelationshipIdTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetUserShapesReference(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.RelationshipIdType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.UserShapesReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.RelationshipIdTypeConverter.CreateOpenXmlElement<DXDrawCharts.UserShapesReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ChartSpaceExtensionList? GetChartSpaceExtensionList(DXDrawCharts.ChartSpace openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.ChartSpaceExtensionList>();
    if (itemElement != null)
      return DMXDrawsCharts.ChartSpaceExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChartSpaceExtensionList(DXDrawCharts.ChartSpace openXmlElement, DMDrawsCharts.ChartSpaceExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.ChartSpaceExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ChartSpaceExtensionListConverter.CreateOpenXmlElement<DXDrawCharts.ChartSpaceExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.ChartSpace? CreateModelElement(DXDrawCharts.ChartSpace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ChartSpace();
      value.Date1904 = GetDate1904(openXmlElement);
      value.EditingLanguage = GetEditingLanguage(openXmlElement);
      value.RoundedCorners = GetRoundedCorners(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.ColorMapOverride = GetColorMapOverride(openXmlElement);
      value.PivotSource = GetPivotSource(openXmlElement);
      value.Protection = GetProtection(openXmlElement);
      value.Chart = GetChart(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.ExternalData = GetExternalData(openXmlElement);
      value.PrintSettings = GetPrintSettings(openXmlElement);
      value.UserShapesReference = GetUserShapesReference(openXmlElement);
      value.ChartSpaceExtensionList = GetChartSpaceExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartSpace? value)
    where OpenXmlElementType: DXDrawCharts.ChartSpace, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDate1904(openXmlElement, value?.Date1904);
      SetEditingLanguage(openXmlElement, value?.EditingLanguage);
      SetRoundedCorners(openXmlElement, value?.RoundedCorners);
      SetStyle(openXmlElement, value?.Style);
      SetColorMapOverride(openXmlElement, value?.ColorMapOverride);
      SetPivotSource(openXmlElement, value?.PivotSource);
      SetProtection(openXmlElement, value?.Protection);
      SetChart(openXmlElement, value?.Chart);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetExternalData(openXmlElement, value?.ExternalData);
      SetPrintSettings(openXmlElement, value?.PrintSettings);
      SetUserShapesReference(openXmlElement, value?.UserShapesReference);
      SetChartSpaceExtensionList(openXmlElement, value?.ChartSpaceExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
